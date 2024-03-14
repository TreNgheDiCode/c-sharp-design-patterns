using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Decorator
{
    // Thành phần cơ bản của việc xây dựng một ngôi nhà.
    public abstract class Component
    {
        public abstract void MakeHouse();
    }

    // Kiến trúc cơ bản của thành phần ngôi nhà.
    // Chúng ta có thể thêm các concrete component khác nhau như: Bedroom, Kitchen, Living Room, etc.
    // Khi đó sẽ đổi tên hàm MakeHouse thành MakeBedroom, MakeKitchen, MakeLivingRoom, etc.
    public class ConcreteComponent : Component
    {
        public override void MakeHouse()
        {
            Console.WriteLine("Nhà cơ bản đã xây xong. Không thể tái xây dựng cấu trúc căn nhà.");
        }
    }

    public abstract class AbstractDecorator : Component
    {
        protected Component? com;

        public void SetTheComponent(Component c)
        {
            com = c;
        }

        public override void MakeHouse()
        {
            com?.MakeHouse(); // Ủy quyền
        }
    }

    public class ConcreteDecoratorEx1 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            base.MakeHouse();

            Console.WriteLine("***Bắt đầu thêm tầng mới***");

            // Thêm một tầng mới.
            AddFloor();
        }

        private static void AddFloor()
        {
            Console.WriteLine("Tầng mới của ngôi nhà đã được xây xong.");
        }
    }

    public class ConcreteDecoratorEx2 : AbstractDecorator
    {
        public override void MakeHouse()
        {
            Console.WriteLine("");
            base.MakeHouse();

            Console.WriteLine("***Bắt đầu sơn nhà***");

            // Sơn nhà.
            PaintTheHouse();
        }

        private static void PaintTheHouse()
        {
            Console.WriteLine("Đã sơn xong nhà.");
        }
    }
}
