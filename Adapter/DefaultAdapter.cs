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
        public static double GetArea(Rect rect)
        {
            return rect.length * rect.width;
        }
    }

    class Triangle
    {
        public double baseT; // base
        public double height; // height
        public Triangle(int b, int h)
        {
            this.baseT = b;
            this.height = h;
        }
    }

    class CalculatorAdapter
    {
        public static double GetArea(Triangle triangle)
        {
            Rect rect = new()
            {
                // Area of Triangle =0.5*base*height
                length = triangle.baseT,
                width = 0.5 * triangle.height
            };

            return Calculator.GetArea(rect);
        }
    }
}
