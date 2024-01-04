using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Singleton
{
    // Code này khá tệ, chỉ để tham khảo cách triển khai sử dụng lock thôi, đừng nên làm theo!
    // "sealed" sẽ làm cho lớp không thể được kế thừa từ bất kì nơi nào khác
    public sealed class DoubleCheckLockSingleton
    {
        /// <summary>
        /// Property - Thuộc tính
        /// </summary>

        // Field
        // Ở đây chúng ta sử dụng "volatile" để đảm bảo quá trình gán biến cho instance được hoàn tất trước khi có thể sử dụng hoặc truy cập.
        private static volatile DoubleCheckLockSingleton instance = null;

        // "readonly" đảm bảo việc khởi tạo đối tượng của padlock được thực hiện trong
        // lúc sử dụng lock, và chỉ được thực hiện 1 lần duy nhất.
        private static readonly object padlock = new object();

        private int numberOfInstances = 0;

        // Get & Set

        // Thuộc tính sẽ gọi đến đối tượng của Singleton (instance). Nếu instance chưa tồn tại, tạo mới và trả về.
        // Ngoài ra, việc sử dụng "public static" đảm bảo rằng đối tượng của Singleton có thể truy cập mọi nơi
        // và việc khởi tạo chỉ được bắt đầu sử dụng khi Instance được gọi lần đầu (shared instance).

        // Tuy nhiên, khác với cách triển khai thông thường (Default Singleton). Sử dụng lock sẽ hao tốn 1 lượng tài nguyên rất lớn
        // khi mỗi một lần instance được gọi thì lock sẽ được kích hoạt.
        public static DoubleCheckLockSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    // Khi 1 thread tiến vào, nó sẽ kích hoạt "lock" trên biến được chia sẻ (shared object) hay trong C# dễ nhận thấy nhất là public static,
                    // trong trường hợp này lock được kích hoạt trên biến "padlock".
                    // Khi sử dụng padlock, đặt lock đằng trước sẽ kiểm tra xem đã có đối tượng nào của padlock được khởi tạo hay chưa trước khi tạo mới.\
                    // Bởi việc sử dụng lock, nên mỗi một lần code chạy, chỉ có duy nhất 1 Thread được tham gia vào thực hiện, do đó sẽ không tồn tại việc xảy ra 2 Thread cùng lúc khởi tạo đối tượng instance của Singleton.
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new DoubleCheckLockSingleton();
                        }
                    }
                }

                return instance;
            }
        }

        /// <summary>
        /// Constructor - Hàm khởi tạo
        /// </summary>

        // Sử dụng "private" để ngăn việc khởi tạo đối tượng bên ngoài lớp bằng việc sử dụng từ khóa "new".
        DoubleCheckLockSingleton()
        {
            Console.WriteLine("Đang khởi tạo đối tượng Singleton bên trong hàm khởi tạo (constructor).");

            // Tăng số đếm của đối tượng Singleton lên 1
            numberOfInstances++;
            Console.WriteLine("Số đối tượng đã khởi tạo = {0}", numberOfInstances);
        }
    }
}
