using Design_Pattern.Singleton;
using System;
using System.Text;

namespace SingletonPatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // In ra tiếng Việt
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("***Singleton Pattern Demo * **\n");

            Console.WriteLine("Khởi tạo đối tượng Singleton s1.");
            NoneSealedNestedDerivedSingleton.NestedDerived s1 = new();

            Console.WriteLine("Khởi tạo đối tượng Singleton s2.");
            NoneSealedNestedDerivedSingleton.NestedDerived s2 = new();

            if (s1 == s2)
            {
                Console.WriteLine("Đã có một đối tượng được khởi tạo trước đó.");
            }
            else
            {
                Console.WriteLine("Tồn tại một đối tượng được khởi tạo khác.");
            }
            Console.Read();
        }
    }
}