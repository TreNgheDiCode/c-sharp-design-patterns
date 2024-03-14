using Design_Pattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Adapter
{
    class Rect
    {
        public double length;
        public double width;
    }
    
    class Calculator
    {
        // Diện tích hình chữ nhật = chiều dài * chiều rộng
        public static double GetArea(Rect rect)
        {
            return rect.length * rect.width;
        }
    }

    class Triangle
    {

        public double baseT; // đáy
        public double height; // cao
        public Triangle(int b, int h)
        {
            baseT = b;
            height = h;
        }
    }

    class CalculatorAdapter
    {
        public static double GetArea(Triangle triangle)
        {
            // Tính diện tích hình tam giác thông qua diện tích hình chữ nhật
            Rect rect = new()
            {
                // Diện tích hình tam giác = 0.5 * đáy * chiều cao
                // Có thể hiểu công thức này thành a * b > hình chữ nhật
                length = triangle.baseT,
                width = 0.5 * triangle.height
            };

            return Calculator.GetArea(rect);
        }
    }
}
