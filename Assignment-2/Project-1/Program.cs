using System;

namespace Matrix
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number(and it will print out prime factors):");
            int Number = Convert.ToInt32(Console.ReadLine());

            PrintPrimeFactors(Number);
        }

        public static void PrintPrimeFactors(int Number)
        {
            int[] Factors;
            const int MaxSize = 1024;
            Factors = new int[MaxSize];
            int place = 0;
            //遍历找到素数组
            for (int i = 2; i <= Number; i++)
            {
                bool IsPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) IsPrime = false;
                }
                if (IsPrime)
                {
                    Factors[++place] = i;
                    //Console.WriteLine(Factors[place]);
                }
            }
            Console.WriteLine("The Prime Factor of " + Number + " is as below:");
            int Adder = 1;
            //在素数组的范围内进行质因数分解，并将其输出。
            while (Number >= 2 && Adder <= place)
            {
                bool OutFlag = false;
                while (Number % Factors[Adder] == 0)
                {
                    OutFlag = true;
                    Number = Number / Factors[Adder];
                }
                if (OutFlag)
                {
                    Console.WriteLine(Factors[Adder]);
                }
                Adder++;
            }
        }
    }
}