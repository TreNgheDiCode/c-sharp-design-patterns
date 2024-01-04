using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Singleton
{
    // "sealed" sẽ làm cho lớp không thể được kế thừa từ bất kì nơi nào khác
    public sealed class Singleton
    {
        /// <summary>
        /// Property - Thuộc tính
        /// </summary>

        // Field

        // "readonly" đảm bảo việc khởi tạo đối tượng Singleton được thực hiện trong quá trình
        // khởi tạo đối tượng của class, và là duy nhất.
        private static readonly Singleton instance = new Singleton();

        private int numberOfInstances = 0;

        // Get & Set

        // Thuộc tính sẽ gọi đến đối tượng của Singleton (instance). Nếu instance chưa tồn tại, tạo mới và trả về.
        // Ngoài ra, việc sử dụng "public static" đảm bảo rằng đối tượng của Singleton có thể truy cập mọi nơi
        // và việc khởi tạo chỉ được bắt đầu sử dụng khi Instance được gọi lần đầu
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Constructor - Hàm khởi tạo
        /// </summary>

        // Sử dụng "private" để ngăn việc khởi tạo đối tượng bên ngoài lớp bằng việc sử dụng từ khóa "new".
        private Singleton()
        {
            Console.WriteLine("Đang khởi tạo đối tượng Singleton bên trong hàm khởi tạo (constructor).");

            // Tăng số đếm của đối tượng Singleton lên 1
            numberOfInstances++;
            Console.WriteLine("Số đối tượng đã khởi tạo = {0}", numberOfInstances);
        }
    }
}
