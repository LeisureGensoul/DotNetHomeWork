using System;
using System.Transactions;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shape shape = new Triangle(1, 3, 3);
            Shape shape2 = new Rectangle(2, 3);
            Shape shape3 = new Square(6);
            Console.WriteLine(shape.CaculateArea());
            Console.WriteLine(shape2.CaculateArea());
            Console.WriteLine(shape3.CaculateArea());

            Console.WriteLine(shape.JudgeShape());
            Console.WriteLine(shape2.JudgeShape());
            Console.WriteLine(shape3.JudgeShape());

        }
    }
    public abstract class Shape
    {
        public abstract double CaculateArea();
        public abstract bool JudgeShape();
    }
    public class Triangle : Shape
    {
        private readonly double a, b, c;
        public Triangle(double a = 1, double b = 1, double c = 1)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public override double CaculateArea()
        {
            double p = (a + b + c) / 2;
            double Area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Area;
        }

        public override bool JudgeShape()
        {
            return ((a + b > c) && (a + c > b) && (b + c > a));
        }
    }
    public class Rectangle : Shape
    {
        private readonly double length, width;
        public Rectangle(double length = 1, double width = 1)
        {
            this.length = length;
            this.width = width;
        }
        public override double CaculateArea()
        {
            double Area = length * width;
            return Area;
        }

        public override bool JudgeShape()
        {
            return ((length >= 0) && (width > 0));
        }
    }
    public class Square : Rectangle
    {
        public Square(double side = 1) : base(side, side) { }
    }
}