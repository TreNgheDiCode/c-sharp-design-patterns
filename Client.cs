using Design_Pattern.AbstractFactory;
using Design_Pattern.Adapter;
using Design_Pattern.Builder;
using Design_Pattern.Decorator;
using Design_Pattern.Facade;
using Design_Pattern.FlyWeight;
using Design_Pattern.Prototype;
using Design_Pattern.Singleton;
using System.Text;
using Design_Pattern.Proxy;
using Design_Pattern.Composite;
using Design_Pattern.Template;

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
        //    Singleton s1 = Singleton.Instance;

        //    Console.WriteLine("Khởi tạo đối tượng Singleton s2.");
        //    Singleton s2 = Singleton.Instance;

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
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***Prototype Pattern Demo * **\n");

        //    // Khởi tạo các bản sản phẩm là Nano và Ford (đều có phụ tùng là Basic Car)
        //    // Dùng Basic Car dạng như là 1 khuôn xe hơi nhưng dùng mẫu mã khác nhau để thể hiện sản phẩm khác nhau
        //    // trên ModelName và Price
        //    BasicCar nano_base = new Nano("Green Nano") { Price = 100000 };
        //    BasicCar ford_base = new Ford("Ford Yellow") { Price = 500000 };

        //    BasicCar bc1;

        //    // Clone từ sản phẩm gốc (không nhầm lẫn với mẫu gốc là BasicCar nhé), ở đây là Nano
        //    bc1 = nano_base.Clone();
        //    bc1.Price = nano_base.Price + BasicCar.SetPrice();
        //    Console.WriteLine("Car is: {0}, and it's price is Rs. {1} ", bc1.ModelName, bc1.Price);

        //    // Clone từ sản phẩm gốc (không nhầm lẫn với mẫu gốc là BasicCar nhé), ở đây là Ford
        //    bc1 = ford_base.Clone();
        //    bc1.Price = ford_base.Price + BasicCar.SetPrice();
        //    Console.WriteLine("Car is: {0}, and it's price is Rs. {1}", bc1.ModelName, bc1.Price);
        //    Console.ReadLine();
        //}
        #endregion

        #region Builder
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.Unicode;

        //    Console.WriteLine("***Builder Pattern Demo * **");
        //    IBuilder b1 = new Car("Ford");
        //    IBuilder b2 = new MotorCycle("Honda");

        //    // Làm xe hơi
        //    Director.Construct(b1);
        //    Product p1 = b1.GetVehicle();
        //    p1.Show();

        //    // Làm xe máy
        //    Director.Construct(b2);
        //    Product p2 = b2.GetVehicle();
        //    p2.Show();

        //    Console.ReadLine();
        //}
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

        #region Proxy
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***Proxy Pattern Demo * **\n");
        //    Proxy px = new();
        //    px.DoSomeWork();
        //    Console.ReadKey();
        //}
        #endregion

        #region Decorator
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.UTF8;

        //    Console.WriteLine("***Decorator pattern Demo * **\n");

        //    // Tạo ra nhà cơ bản
        //    ConcreteComponent cc = new();

        //    // Thêm tàng mới cho ngôi nhà
        //    ConcreteDecoratorEx1 decorator1 = new();
        //    // Truyền vào cấu trúc hiện tại của ngôi nhà
        //    decorator1.SetTheComponent(cc);
        //    decorator1.MakeHouse();

        //    // Sơn nhà
        //    ConcreteDecoratorEx2 decorator2 = new();
        //    // Truyền vào cấu trúc hiện tại sau khi đã thêm tầng mới
        //    decorator2.SetTheComponent(decorator1);
        //    decorator2.MakeHouse();

        //    Console.ReadKey();
        //}
        #endregion

        #region Adapter
        //static void Main(string[] args)
        //{
        //    // In ra tiếng Việt
        //    Console.OutputEncoding = Encoding.Unicode;

        //    Console.WriteLine("***Adapter Pattern Demo * **\n");

        //    Triangle t = new(20, 10);
        //    Console.WriteLine("Diện tích hình tam giác là " + CalculatorAdapter.GetArea(t) + " mét vuông");

        //    Console.ReadKey();
        //}
        #endregion

        #region Facade
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***Facade Pattern Demo * **\n");

        //    // Creating Robots
        //    RobotFacade.ConstructMilanoRobot();
        //    RobotFacade.ConstructRobonautRobot();

        //    // Destroying robots
        //    RobotFacade.DestroyMilanoRobot();
        //    RobotFacade.DestroyRobonautRobot();

        //    Console.ReadLine();
        //}
        #endregion

        #region FlyWeight
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***Flyweight Pattern Demo * **\n");
        //    RobotFactory myfactory = new();
        //    IRobot shape =
        //    myfactory.GetRobotFromFactory("Small");
        //    shape.Print();
        //    /*
        //     * Now we are trying to get the 2 more
        //    Small robots.
        //     * Note that: now onwards we need not
        //    create additional small robots because
        //    we have already created one of this
        //    category
        //    */
        //    for (int i = 0; i < 2; i++)
        //    {
        //        shape =
        //        myfactory.GetRobotFromFactory("Small");
        //        shape.Print();
        //    }

        //    int NumOfDistinctRobots = myfactory.TotalObjectsCreated;
        //    Console.WriteLine("\n Now, total numbers of distinct robot objects is = {0}\n", NumOfDistinctRobots);
        //    /*
        //     * Here we are trying to get the 5 more Large robots.
        //     * Note that: now onwards we need not
        //    create additional small robots because we have already
        //    created one of this category
        //    */
        //    for (int i = 0; i < 5; i++)
        //    {
        //        shape =
        //        myfactory.GetRobotFromFactory("Large");
        //        shape.Print();
        //    }

        //    NumOfDistinctRobots = myfactory.TotalObjectsCreated;
        //    Console.WriteLine("\n Distinct Robot objects created till now = {0}", NumOfDistinctRobots);

        //    Console.ReadKey();
        //}
        #endregion

        #region Composite
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("***Composite Pattern Demo * **");

        //    // Principal of the college
        //    CompositeEmployee Principal = new("Dr.S.Som(Principal)", "PlanningSupervising-Managing");

        //    // The College has 2 Head of Departments - One from Mathematics, 1 from Computer Sc.
        //    CompositeEmployee hodMaths = new("Mrs.S.Das(HOD-Maths)", "Maths");
        //    CompositeEmployee hodCompSc = new("Mr. V.Sarcar(HOD-CSE)", "ComputerSc.");

        //    // 2 other teachers works in Mathematics department
        //    Employee mathTeacher1 = new("Math Teacher - 1", "Maths");
        //    Employee mathTeacher2 = new("Math Teacher - 2", "Maths");

        //    // 3 other teachers works in Computer Sc. department
        //    Employee cseTeacher1 = new("CSE Teacher - 1","Computer Sc.");
        //    Employee cseTeacher2 = new("CSE Teacher - 2", "Computer Sc.");
        //    Employee cseTeacher3 = new("CSE Teacher - 3", "Computer Sc.");

        //    // Teachers of Mathematics directly reports to HOD - Maths
        //    hodMaths.Add(mathTeacher1);
        //    hodMaths.Add(mathTeacher2);

        //    // Teachers of Computer Sc. directly reports to HOD - CSE
        //    hodCompSc.Add(cseTeacher1);
        //    hodCompSc.Add(cseTeacher2);
        //    hodCompSc.Add(cseTeacher3);

        //    // Principal is on top of college
        //    // HOD -Maths and Comp. Sc directly reports to him
        //    Principal.Add(hodMaths);
        //    Principal.Add(hodCompSc);

        //    // Printing the leaf-nodes and branche in the same way.
        //    // i.e. in each case, we are calling PrintStructures()
        //    // methodConsole.WriteLine("\n Testing the structure of a Principal object");

        //    // Prints the complete structure
        //    Principal.PrintStructures();
        //    Console.WriteLine("\n Testing the structure of a HOD object:");
        //    Console.WriteLine("Teachers working at Computer Science department: ");

        //    //Prints the details of Computer Sc. department
        //    hodCompSc.PrintStructures();

        //    //Leaf node
        //    Console.WriteLine("\n Testing the structure of a leaf node: ");
        //    mathTeacher1.PrintStructures();

        //    //Suppose, one computer teacher is leaving now from the organization.
        //    hodCompSc.Remove(cseTeacher2);
        //    Console.WriteLine("\n After CSE Teacher - 2 resigned, the organization has following members: ");
        //    Principal.PrintStructures();

        //    Console.ReadKey();
        //}
        #endregion

        #region Template Method
        static void Main(string[] args)
        {
            // In ra tiếng Việt
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("***Template Method Pattern Demo * **\n");

            SimpleCrawlerApp tuoitre = new TuoiTreCrawler();
            tuoitre.Crawl("https://tuoitre.vn/thu-tuong-lam-ro-vi-sao-doanh-nghiep-kho-tiep-can-von-du-tien-gui-vao-ngan-hang-tang-2024031409365941.htm");

            Console.ReadLine();
        }
        #endregion
    }
}