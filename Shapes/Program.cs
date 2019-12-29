using System;

namespace Shapes
{
    class Shape
    {
        public int x;
        public int y;
        public string color;
    }
    class Circle : Shape
    {
        public double r;
        public readonly double PI = 3.14;
        public double Area()
        {
            return r * r * PI;
        }
        
    }
    class Square
    {
        public double a;
        public double Area()
        {
            return a * a;
        }
    }
    class Rectangle
    {
        public double a;
        public double b;
        public double Area()
        {
            return a * b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            c.r = 2;
            c.x = 100;
            c.y = 100;
            c.color = "red";
            System.Console.WriteLine(c.Area());

            Square s = new Square();
            s.a = 2;
            c.x = 100;
            c.y = 100;
            c.color = "red";
            System.Console.WriteLine(s.Area());

            Rectangle r = new Rectangle();
            r.a = 2;
            r.b = 2;
            c.x = 100;
            c.y = 100;
            c.color = "red";
            System.Console.WriteLine(r.Area());
        }
    }
}
