using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Proxy
{
    /// <summary>
    /// Đối tượng thực sự cần được truy cập thông qua Proxy
    /// </summary>
    public abstract class Subject
    {
        public abstract void DoSomeWork();
    }

    /// <summary>
    /// Định nghĩa các đối tượng thực hiện các công việc khác nhau
    /// </summary>
    public class ConcreteSubject : Subject
    {
        public override void DoSomeWork()
        {
            Console.WriteLine("Đã thực hiện chức năng của ConcreteSubject");
        }
    }

    /// <summary>
    /// Lớp Proxy chịu trách nhiệm thực hiện một số công việc được định nghĩa từ Subject
    /// Có thể có nhiều proxy khác nhau, mỗi proxy sẽ thực hiện các công việc khác nhau từ Subject
    /// </summary>
    public class Proxy : Subject
    {
        Subject? cs;

        public override void DoSomeWork()
        {
            Console.WriteLine("Đang khởi động...");

            // Lazy initialization: Chỉ sử dụng khi được gọi đến
            cs ??= new ConcreteSubject();

            cs.DoSomeWork();
        }
    }
}
