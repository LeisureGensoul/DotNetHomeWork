using System;
using System.Collections;
using System.Security.Principal;
using System.Transactions;

namespace MyApp
{


    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            Shape shape = new Triangle();
            Shape shape2 = new Rectangle();
            Shape shape3 = new Square();
            Console.WriteLine(shape.CaculateArea());
            Console.WriteLine(shape2.CaculateArea());
            Console.WriteLine(shape3.CaculateArea());
            */
            
            WorkPlace FactoryWork = new WorkPlace();
            FactoryWork.WorkNow();
        }
    }

    public interface FactoryTest
    {
        public void factoryTest();
    }

    public abstract class Shape : FactoryTest
    {
        public abstract double CaculateArea();
        public abstract bool JudgeShape();
        public abstract void factoryTest();
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
            return this.JudgeShape() ? Area : 0;
        }

        public override bool JudgeShape()
        {
            return ((a + b > c) && (a + c > b) && (b + c > a));
        }
        public override void factoryTest()
        {
            Console.WriteLine("This is a Triangle!");
            Console.WriteLine("Whether Sufficient : " + this.JudgeShape());
            Console.WriteLine("The three length is " + this.a + "  " + this.b + "  " + this.c);
            Console.WriteLine("The Area is " + this.CaculateArea());
            Console.WriteLine();
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
            return this.JudgeShape() ? Area: 0;
        }


        public override bool JudgeShape()
        {
            return ((length >= 0) && (width > 0));
        }
        public override void factoryTest()
        {
            Console.WriteLine("This is a Rectangle!");
            Console.WriteLine("Whether Sufficient : " + this.JudgeShape());
            Console.WriteLine("The two length is " + this.length + "  " + this.width);
            Console.WriteLine("The Area is " + this.CaculateArea());
            Console.WriteLine();
        }  
    }
    public class Square : Rectangle
    {
        private readonly double side;
        public Square(double side = 1) : base(side, side) => this.side = side;
        public override void factoryTest()
        {
            Console.WriteLine("This is a Square!");
            Console.WriteLine("Whether Sufficient : " + this.JudgeShape());
            Console.WriteLine("The side length is " + this.side);
            Console.WriteLine("The Area is " + this.CaculateArea());
            Console.WriteLine();
        }
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(string choose)
        {
            Random rd = new Random();
            double d1, d2, d3;
            //Random类还提供了Random.NextDouble()方法产生一个范围在0.0-1.0之间的随机的双精度浮点数；
            
            //使得满足形状要求的可能性为60%。
            d1 = rd.NextDouble() * 100;
            d2 = rd.NextDouble() * 100;
            d3 = rd.NextDouble() * 100;

            Shape shape = null;
            switch (choose)
            {
                case "Triangle":
                    shape = new Triangle(d1, d2, d3);
                    break;
                case "Rectangle":
                    d1 -= 20;
                    d2 -= 20;
                    shape = new Rectangle(d1, d2);
                    break;
                case "Square":
                    d1 -= 50;
                    shape = new Square(d1);
                    break;
            }
            return shape;
        }
    }

    public class WorkPlace
    {
        public void WorkNow()
        {
            ShapeFactory simpleFactory = new ShapeFactory();//实例化工厂
            ArrayList AllShape = new ArrayList();

            string[] types = new string[3];
            types[0] = "Rectangle";
            types[1] = "Triangle";
            types[2] = "Square";

            //int iSeed = 16;
            Random rd = new Random();

            const int TypeSize = 3;
            const int Num = 500;
            const int RequiredNum = 10;

            double TotalArea = 0;
            int TotalNum = 0;

            for (int i = 0; i < Num; i++)
            {
                if (TotalNum >= RequiredNum)
                {
                    break;
                }
                int iResult = rd.Next() % TypeSize;
                Shape temp = ShapeFactory.CreateShape(types[iResult]);
                if (temp.JudgeShape())
                {
                    TotalNum++;
                    AllShape.Add(temp);
                    TotalArea += temp.CaculateArea();

                    Console.WriteLine("This is the " + TotalNum + "th one");
                    temp.factoryTest();
                }

            }
            Console.WriteLine(TotalArea);

        }
    }
}