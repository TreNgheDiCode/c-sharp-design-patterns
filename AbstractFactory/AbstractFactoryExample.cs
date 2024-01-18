using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.AbstractFactory
{
    #region Bài toán đặt ra
    // Tôi muốn tạo một cửa hàng bán nội thất và một nhóm sản phẩm mình cần quản lý là: Bàn cà phê, ghế, sofa.
    // 3 nhóm sản phẩm bàn cà phê, ghế, sofa này có nhiều loại mẫu mã khác nhau: Art Deco, Victorian, Modern.
    #endregion

    /// <summary>
    /// Định nghĩa, thiết kế, làm khuôn
    /// </summary>
    #region Abstract Products - Phân theo loại hình
    // Khởi tạo 3 loại hình khác nhau: Bàn cà phê, ghế, sofa
    public interface IChair
    {
        void Material();
        void Action();
    }
    public interface ISofa
    {
        void Material();
        void Action();
    }
    public interface ITable
    {
        void Material();
        void Action();
    }
    #endregion 

    #region Bộ sưu tập Art Deco - Concrete Products
    // Định nghĩa các đặc chủng của Art Deco
    class ArtDecoChair : IChair
    {
        public void Action()
        {
            Console.WriteLine("Cái ghế nói: Tui có thể ngồi lên!");
        }

        public void Material()
        {
            Console.WriteLine("Cái ghế nói: style tui là ART DECO");
        }
    }
    class ArtDecoSofa : ISofa
    {
        public void Action()
        {
            Console.WriteLine("Cái sofa nói: Tui có thể nằm lên");
        }

        public void Material()
        {
            Console.WriteLine("Cái sofa nói: style tui là ART DECO");
        }
    }

    class ArtDecoTable : ITable
    {
        public void Action()
        {
            Console.WriteLine("Cái bàn cà phê nói: Tui là chỗ để ly cốc");
        }

        public void Material()
        {
            Console.WriteLine("Cái bàn cà phê nói: style tui là ART DECO");
        }
    }
    #endregion

    #region Bộ sưu tập Victorian - Concrete Products
    // Định nghĩa các đặc chủng của Victorian
    class VictorianChair : IChair
    {
        public void Action()
        {
            Console.WriteLine("Cái ghế nói: Tui đẹp và tui biết điều đó!");
        }

        public void Material()
        {
            Console.WriteLine("Cái ghế nói: style tui là VICTORIAN");
        }
    }
    class VictorianSofa : ISofa
    {
        public void Action()
        {
            Console.WriteLine("Cái sofa nói: Nằm lên tui là thấy sang chảnh!");
        }

        public void Material()
        {
            Console.WriteLine("Cái sofa nói: style tui là VICTORIAN");
        }
    }
    class VictorianTable : ITable
    {
        public void Action()
        {
            Console.WriteLine("Cái bàn cà phê nói: Dùng tui đi!");
        }

        public void Material()
        {
            Console.WriteLine("Cái bàn cà phê nói: style tui là VICTORIAN");
        }
    }
    #endregion

    #region Bộ sưu tập Modern - Concrete Products
    // Định nghĩa các đặc chủng của Modern
    class ModernChair : IChair
    {
        public void Action()
        {
            Console.WriteLine("Cái ghế nói: Tui hiện đại!");
        }

        public void Material()
        {
            Console.WriteLine("Cái ghế nói: style tui là MODERN");
        }
    }
    class ModernSofa : ISofa
    {
        public void Action()
        {
            Console.WriteLine("Cái sofa nói: Giường này ổn cái lưng!");
        }

        public void Material()
        {
            Console.WriteLine("Cái sofa nói: style tui là MODERN");
        }
    }
    class ModernTable : ITable
    {
        public void Action()
        {
            Console.WriteLine("Cái bàn cà phê nói: Bàn này hại điện!");
        }

        public void Material()
        {
            Console.WriteLine("Cái bàn cà phê nói: style tui là MODERN");
        }
    }
    #endregion

    /// <summary>
    /// Sản xuất
    /// </summary>
    #region Abstract Factory - Đại lý nội thất (Nhà máy tổng)
    public interface IFurnitureFactory
    {
        // Lưu trữ và định nghĩa các lệnh sản xuất
        IChair CreateChair();
        ISofa CreateSofa();
        ITable CreateTable();
    }
    #endregion

    #region Nhà máy sản xuất nội thất ArtDeco - Concrete Factory
    public class ArtDecoFurnitureFactory : IFurnitureFactory
    {
        // Sản xuất 1 đặc chủng duy nhất là Art Deco
        public IChair CreateChair()
        {
            return new ArtDecoChair();
        }
        public ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
        public ITable CreateTable()
        {
            return new ArtDecoTable();
        }
    }
    #endregion

    #region Nhà máy sản xuất nội thất Victorian - Concrete Factory
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        // Sản xuất 1 đặc chủng duy nhất là Victorian
        public IChair CreateChair()
        {
            return new VictorianChair();
        }
        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public ITable CreateTable()
        {
            return new VictorianTable();
        }
    }
    #endregion

    #region Nhà máy sản xuất nội thất Modern - Concrete Factory
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        // Sản xuất 1 đặc chủng duy nhất là Modern
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public ITable CreateTable()
        {
            return new ModernTable();
        }
    }
    #endregion
}
