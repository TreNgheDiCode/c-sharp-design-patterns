using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Singleton
{
    // Code này khá tệ, chỉ để tham khảo cách triển khai sử dụng lock thôi, đừng nên làm theo!
    // "sealed" sẽ làm cho lớp không thể được kế thừa từ bất kì nơi nào khác
    public sealed class NoneThreadSafeSingleton
    {
        /// <summary>
        /// Property - Thuộc tính
        /// </summary>

        // Field

        // Cách triển khai này được gọi là NoneThreadSafe khi chúng ta quyết định bỏ đi "readonly"
        // và đơn giản hóa hơn quá trình khởi tạo bằng thuộc tính Get & Set, kiểm tra và gán trực tiếp đối tượng của class khi được gọi tới
        private static NoneThreadSafeSingleton? instance = null;

        private int numberOfInstances = 0;

        // Get & Set

        // Thuộc tính sẽ gọi đến đối tượng của Singleton (instance). Nếu instance chưa tồn tại, tạo mới và trả về.
        // Ngoài ra, việc sử dụng "public static" đảm bảo rằng đối tượng của Singleton có thể truy cập mọi nơi
        // và việc khởi tạo chỉ được bắt đầu sử dụng khi Instance được gọi lần đầu (shared instance).

        // Tuy nhiên, khác với cách triển khai thông thường (Default Singleton). Cách này sẽ tồn tại nguy cơ trong môi trường
        // đa luồng (multithreaded), dẫn tới class sẽ tồn tại nhiều hơn 1 đối tượng được khởi tạo
        public static NoneThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NoneThreadSafeSingleton();
                }

                return instance;
            }
        }

        /// <summary>
        /// Constructor - Hàm khởi tạo
        /// </summary>

        // Sử dụng "private" để ngăn việc khởi tạo đối tượng bên ngoài lớp bằng việc sử dụng từ khóa "new".
        private NoneThreadSafeSingleton()
        {
            Console.WriteLine("Đang khởi tạo đối tượng Singleton bên trong hàm khởi tạo (constructor).");

            // Tăng số đếm của đối tượng Singleton lên 1
            numberOfInstances++;
            Console.WriteLine("Số đối tượng đã khởi tạo = {0}", numberOfInstances);
        }
    }
}
