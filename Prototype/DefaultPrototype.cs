namespace Design_Pattern.Prototype
{
    // Bản gốc (hoặc có thể coi là khuôn mẫu)
    public abstract class BasicCar
    {
        public string ModelName { get; set; } = null!;
        public int Price { get; set; } // Khi không gán gì hết, mặc định là 0

        /// <summary>
        /// Khi gọi tới sẽ trả về giá ngẫu nhiên
        /// </summary>
        /// <returns></returns>
        public static int SetPrice()
        {
            Random r = new();
            int p = r.Next(200000, 500000);
            int price = p;
            return price;
        }

        // Phương thức Clone (ràng buộc để mỗi sản phẩm kế thừa từ bản gốc này đều phải clone từ bản gốc này)
        public abstract BasicCar Clone();
    }

    // Sản phẩm clone
    public class Nano : BasicCar
    {
        public Nano(string m)
        {
            ModelName = m;
        }

        // Trả về clone của Nano (dù bản chất bên ngoài thể hiện là Nano, nhưng phụ tùng là của BasicCar - do tính kế thừa)
        public override BasicCar Clone()
        {
            return (Nano)MemberwiseClone(); //shallow Clone
        }
    }

    // Sản phẩm clone
    public class Ford : BasicCar
    {
        public Ford(string m)
        {
            ModelName = m;
        }

        // Trả về clone của Ford (dù bản chất bên ngoài thể hiện là Ford, nhưng phụ tùng là của BasicCar - do tính kế thừa)
        public override BasicCar Clone()
        {
            return (Ford)MemberwiseClone();
        }
    }

}
