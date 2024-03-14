namespace Design_Pattern.Builder
{
    // Builder giống kiểu như một hướng dẫn cho việc xây dựng một sản phẩm gồm những công đoạn nào.
    interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    } 
    
    // Mẫu mã được xây dựng từ các công đoạn xây dựng của IBuilder.
    class Car : IBuilder
    {
        private readonly string brandName;
        private readonly Product product;

        public Car(string brand)
        {
            product = new Product();
            brandName = brand;
        }

        public void StartUpOperations()
        { 
            // In ra mẫu mã của xe hơi
            product.Add(string.Format("Mẫu mã: {0}",brandName));
        }
        
        public void BuildBody()
        {
            product.Add("Xây dựng thân xe hơi thành công");
        }
        public void InsertWheels()
        {
            product.Add("Đã lắp ráp 4 bánh vào xe");
        }

        public void AddHeadlights()
        {
            product.Add("Đã thêm vào 2 đèn xe");
        }

        public void EndOperations()
        { 
            // Nothing in this case
        }

        public Product GetVehicle()
        {
            return product;
        }
    }

    // Mẫu mã được xây dựng từ các công đoạn xây dựng của IBuilder.
    class MotorCycle : IBuilder
    {
        private readonly string brandName;
        private readonly Product product;

        public MotorCycle(string brand)
        {
            product = new Product();
            brandName = brand;
        }

        public void StartUpOperations()
        { 
            // Nothing in this case
        }

        public void BuildBody()
        {
            product.Add("Xây dựng thân xe máy thành công");
        }

        public void InsertWheels()
        {
            product.Add("Đã thêm vào 2 bánh");
        }

        public void AddHeadlights()
        {
            product.Add("Đã thêm vào 1 đèn xe");
        }

        public void EndOperations()
        {
            // Thể hiện mẫu mã ở cuối công đoạn
            product.Add(string.Format("Mẫu mã: {0}", this.brandName));
        }

        public Product GetVehicle()
        {
            return product;
        }
    } 

    // "Product"
    class Product
    {
        // Ở đây có thể dùng bất cứ cấu trúc dữ liệu danh sách nào tùy thích.
        // Mình sử dụng LinkedList bởi cơ chế của nó giúp việc thêm và xóa phần tử nhanh hơn.
        // Còn nếu cần đến chức năng tìm kiếm phần tử thì mình sẽ sử dụng List.
        private readonly LinkedList<string> parts;

        public Product()
        {
            parts = new LinkedList<string>();
        }
        
        public void Add(string part)
        {
            //Adding parts
            parts.AddLast(part);
        }
        
        public void Show()
        {
            Console.WriteLine("\nProduct completed as below :");

            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
    
    // "Director" - Hay cũng có thể coi là đạo diễn
    // Đạo diễn sẽ chỉ đạo cho các công đoạn xây dựng của IBuilder được thực hiện theo trình tự nào.
    class Director
    {
        // Các bước thực hiện, tùy theo thực tế mà những bước này sẽ phức tạp.
        public static void Construct(IBuilder builder)
        {
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
