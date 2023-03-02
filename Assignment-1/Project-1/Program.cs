using System;

namespace myApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Two Operands:");
                double OperandFront = Convert.ToDouble(Console.ReadLine());
                double OperandBehind = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter The Operator:");
                string Operator = Console.ReadLine();
                Calculator cal = new Calculator();
                switch (Operator)
                {
                    case "+":
                        Console.WriteLine("Result of " + OperandFront + " + " + OperandBehind + " is " + cal.Addition(OperandFront, OperandBehind));
                        break;
                    case "-":
                        Console.WriteLine("Result of " + OperandFront + " - " + OperandBehind + " is " + cal.Subtraction(OperandFront, OperandBehind));
                        break;
                    case "*":
                        Console.WriteLine("Result of " + OperandFront + " * " + OperandBehind + " is " + cal.Multiplication(OperandFront, OperandBehind));
                        break;
                    case "/":
                        Console.WriteLine("Result of " + OperandFront + " / " + OperandBehind + " is " + cal.Division(OperandFront, OperandBehind));
                        break;
                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
    internal class Calculator
    {
        public double Addition(double OperandFront, double OperandBehind)
        {
            return OperandFront + OperandBehind;
        }
        public double Subtraction(double OperandFront, double OperandBehind)
        {
            return OperandFront - OperandBehind;
        }
        public double Multiplication(double OperandFront, double OperandBehind)
        {
            return OperandFront * OperandBehind;
        }
        public double Division(double OperandFront, double OperandBehind)
        {
            return (OperandFront / OperandBehind);
        }
    }
}