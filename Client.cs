using Design_Pattern.AbstractFactory;
using Design_Pattern.Prototype;
using Design_Pattern.Singleton;
using System.Text;

namespace DesignPatternsEx
{
    class Client
    {
        #region Singleton
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.Unicode;

        //    Console.WriteLine("***Singleton Pattern Demo * **\n");

        //    Console.WriteLine("Khởi tạo đối tượng Singleton s1.");
        //    NoneSealedNestedDerivedSingleton.NestedDerived s1 = new();

        //    Console.WriteLine("Khởi tạo đối tượng Singleton s2.");
        //    NoneSealedNestedDerivedSingleton.NestedDerived s2 = new();

        //    if (s1 == s2)
        //    {
        //        Console.WriteLine("Đã có một đối tượng được khởi tạo trước đó.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Tồn tại một đối tượng được khởi tạo khác.");
        //    }
        //    Console.Read();
        //}
        #endregion

        #region Prototype
        static void Main(string[] args)
        {
            Console.WriteLine("***Prototype Pattern Demo * **\n");

            // Khởi tạo các bản sản phẩm là Nano và Ford (đều có phụ tùng là Basic Car)
            // Dùng Basic Car dạng như là 1 khuôn xe hơi nhưng dùng mẫu mã khác nhau để thể hiện sản phẩm khác nhau
            // trên ModelName và Price
            BasicCar nano_base = new Nano("Green Nano") {Price = 100000};
            BasicCar ford_base = new Ford("Ford Yellow") {Price = 500000};
            
            BasicCar bc1;

            // Clone từ sản phẩm gốc (không nhầm lẫn với mẫu gốc là BasicCar nhé), ở đây là Nano
            bc1 = nano_base.Clone();
            bc1.Price = nano_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ",bc1.ModelName,bc1.Price);

            // Clone từ sản phẩm gốc (không nhầm lẫn với mẫu gốc là BasicCar nhé), ở đây là Ford
            bc1 = ford_base.Clone();
            bc1.Price = ford_base.Price + BasicCar.SetPrice();
            Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
            Console.ReadLine();
        }
        #endregion

        #region Abstract Factory
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.UTF8;

        //    Console.WriteLine("***Abstract Factory Pattern Demo***\n");
        //    // Order một chú chó Hoang dã từ Đại lý
        //    // Đại lý sẽ chỉ định nhà máy chịu trách nhiệm sản xuất động vật Hoang dã
        //    IAnimalFactory wildAnimalFactory = new WildAnimalFactory();

        //    // Nhà máy sử dụng khuôn để làm ra sản phẩm
        //    IDog wildDog = wildAnimalFactory.CreateDog();

        //    // Nhận hàng và test sản phẩm
        //    wildDog.Speak();
        //    wildDog.Action();

        //    // Sau khi xong, tiếp tục order một con hổ Hoang dã từ Đại lý
        //    // Nhà máy sử dụng khuôn để làm ra sản phẩm
        //    ITiger wildTiger = wildAnimalFactory.CreateTiger();

        //    // Nhận hàng và test sản phẩm
        //    wildTiger.Speak();
        //    wildTiger.Action();

        //    Console.WriteLine("******************");

        //    // Order một chú chó Thú cưng từ Đại lý
        //    // Đại lý sẽ chỉ định nhà máy chịu trách nhiệm sản xuất động vật Thú cưng
        //    IAnimalFactory petAnimalFactory = new PetAnimalFactory();

        //    // Nhà máy sử dụng khuôn để làm ra sản phẩm
        //    IDog petDog = petAnimalFactory.CreateDog();

        //    // Nhận hàng và test sản phẩm
        //    petDog.Speak();
        //    petDog.Action();

        //    // Sau khi xong, tiếp tục order một con hổ Thú cưng từ Đại lý
        //    // Nhà máy sử dụng khuôn để làm ra sản phẩm
        //    ITiger petTiger = petAnimalFactory.CreateTiger();

        //    // Nhận hàng và test sản phẩm
        //    petTiger.Speak();
        //    petTiger.Action();

        //    Console.ReadLine();
        //}
        #endregion

        #region Abstract Factory - Example 2
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.UTF8;

        //    Console.WriteLine("***Abstract Factory Pattern Demo Example 2***\n");
        //    // Order một cái bàn thuộc dạng Victorian từ Đại lý nội thất (IFurnitureFactory)
        //    // Đại lý sẽ chỉ định nhà máy chịu trách nhiệm sản xuất nội thất thuộc nhóm Victorian
        //    IFurnitureFactory victorianFurnitureFactory = new VictorianFurnitureFactory();

        //    // Nhà máy sử dụng khuôn cái bàn để làm ra sản phẩm
        //    ITable victorianTable = victorianFurnitureFactory.CreateTable();

        //    // Nhận hàng và test sản phẩm
        //    victorianTable.Material();
        //    victorianTable.Action();


        //    Console.ReadLine();

        //    // Code tiếp khúc sau....
        //}
        #endregion
    }
}