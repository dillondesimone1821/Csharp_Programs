using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
        class Rectangle
        {
            private double length;
            private double width;
            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }
            public double GetArea()
            {
                return length * width;
            }
        }
        
    }
}
