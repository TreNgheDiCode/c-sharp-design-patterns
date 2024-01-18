namespace Design_Pattern.AbstractFactory
{
    /// <summary>
    /// Định nghĩa, thiết kế, làm khuôn
    /// </summary>
    #region Abstract Products - Phân theo loại hình
    // Việc thiết kế các Abstract Product là định nghĩa các loại hình sản phẩm khác nhau (Chó và Hổ)
    // Các loại hình này sẽ đem cho Abstract Factory sử dụng để tạo thành các Factory khác nhau.
    // Trong trường hợp dưới, sẽ tạo ra 2 Factory (WildAnimalFactory và PetAnimalFactory)
    // Tuy nhiên trước khi làm điều đó, chúng ta sẽ mở rộng chủng loại cho 2 loại Factory
    // bằng cách tạo ra các Concrete Product sử dụng Abstract Product
    public interface IDog
    {
        void Speak();
        void Action();
    }
    public interface ITiger
    {
        void Speak();
        void Action();
    }
    #endregion 

    #region Bộ sưu tập động vật Hoang dã (Chó và Hổ) - Concrete Products
    // Việc thiết kế các Concrete Products là sử dụng các Abstract Product đã được tạo
    // để tạo ra các biến thể từ loại hình đó (Phân theo đặc chủng)
    class WildDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Chó hoang dã sủa: Gâu gâu.");
        }
        public void Action()
        {
            Console.WriteLine("Chó hoang dã thích chạy nhảy.\n");
        }
    }
    class WildTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Hổ hoang dã kêu: Gào gào.");
        }
        public void Action()
        {
            Console.WriteLine("Hổ hoang dã thích đi săn.\n");
        }
    }
    #endregion

    #region Bộ sưu tập động vật Thú cưng (Hổ và chó) - Concrete Products
    // Việc thiết kế các Concrete Products là sử dụng các Abstract Product đã được tạo
    // để tạo ra các biến thể từ loại hình đó (Phân theo đặc chủng)
    class PetDog : IDog
    {
        public void Speak()
        {
            Console.WriteLine("Chó nhà sủa: Meo meo.");
        }
        public void Action()
        {
            Console.WriteLine("Chó nhà thích ngủ và lười biếng.\n");
        }
    }
    class PetTiger : ITiger
    {
        public void Speak()
        {
            Console.WriteLine("Hổ vườn kêu: Ụt ịt.");
        }
        public void Action()
        {
            Console.WriteLine("Hổ vườn thích bơi trong sở thú.\n");
        }
    }
    #endregion

    /// <summary>
    /// Sản xuất
    /// </summary>
    #region Abstract Factory - Đại lý (Nhà máy tổng)
    // Abstract Factory sẽ lưu trữ các Abstract Product (sau khi đã tạo ra các Concrete Product)
    public interface IAnimalFactory
    {
        // Lưu trữ và định nghĩa các lệnh sản xuất
        IDog CreateDog();
        ITiger CreateTiger();
    }
    #endregion

    #region Nhà máy sản xuất động vật Hoang dã - Concrete Factory
    // Nhận khuôn về các loại hình từ Abstract Factory (lệnh sản xuất)
    // sau đó chỉ trả về 1 đặc chủng duy nhất (động vật Hoang dã)
    public class WildAnimalFactory : IAnimalFactory
    {
        // Sản xuất 1 đặc chủng duy nhất là Hoang dã
        public IDog CreateDog()
        {
            return new WildDog();
        }
        public ITiger CreateTiger()
        {
            return new WildTiger();
        }
    }
    #endregion

    #region Nhà máy sản xuất động vật Thú cưng - Concrete Factory
    // Nhận khuôn về các loại hình từ Abstract Factory (lệnh sản xuất)
    // sau đó chỉ trả về 1 đặc chủng duy nhất (động vật Thú cưng)
    public class PetAnimalFactory : IAnimalFactory
    {
        // Sản xuất 1 đặc chủng duy nhất là Thú cưng
        public IDog CreateDog()
        {
            return new PetDog();
        }
        public ITiger CreateTiger()
        {
            return new PetTiger();
        }
    }
    #endregion
}
