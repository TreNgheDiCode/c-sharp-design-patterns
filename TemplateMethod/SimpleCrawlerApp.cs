using CsvHelper;
using Design_Pattern.Adapter;
using Design_Pattern.TemplateMethod;
using HtmlAgilityPack;
using System.Globalization;
using System.Text;

namespace Design_Pattern.Template
{
    public abstract class SimpleCrawlerApp
    {
        // Template thuật toán crawl dữ liệu từ một URL.

        public async void Crawl(string url)
        {
            string response = await SendHttpRequest(url);
            ParseResponse(response);
            StoreData();
        }

        // Gửi request HTTP đến URL và trả về response.
        protected abstract Task<string> SendHttpRequest(string url);
        // Chép response và trả về dữ liệu dạng object.
        protected abstract void ParseResponse(string response);
        // Lưu trữ dữ liệu.
        protected abstract void StoreData();
    }

    public class TuoiTreCrawler : SimpleCrawlerApp
    {
        // Model báo
        private NewsPaper _newsPaper = new();
        // HttpClient dùng lưu trữ thông tin về HTTP request.
        private readonly HttpClient _httpClient = new();
        protected override async Task<string> SendHttpRequest(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Đảm bảo rằng response không có lỗi.
                _newsPaper.Url = url;
                return await response.Content.ReadAsStringAsync(); // Trả về response dạng string.
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Lỗi không xác định xảy ra: {0}", ex.Message);
                return string.Empty;
            }
        }

        protected override void ParseResponse(string response)
        {
            // Lưu trữ response dưới dạng HTML document.
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(response);

            // Tìm tiêu đề trang
            var titleNode = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            // Tìm tiêu đề bài báo
            var heading = htmlDoc.DocumentNode.SelectSingleNode("//*[@data-role='title']");
            var content = htmlDoc.DocumentNode.SelectSingleNode("//*[@data-role='content']");

            // Lưu vào báo
            _newsPaper.TieuDeWeb = titleNode.InnerText;
            _newsPaper.TieuDeBao = heading.InnerText;
            _newsPaper.NoiDung = content.InnerText;
        }

        protected override void StoreData()
        {
            var path = @"D:\CodingLife\DesignPatterns\Design Pattern\data.csv";

            bool fileExists = File.Exists(path);

            // Viết báo vào file csv
            using var writer = new StreamWriter(path, fileExists, Encoding.UTF8);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            if (!fileExists)
            {
                csv.WriteHeader<NewsPaper>();
            }

            csv.NextRecord();
            csv.WriteRecord(_newsPaper);
        }
    }
}
