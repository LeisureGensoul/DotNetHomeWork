using System;

namespace Matrix
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the range of the matrix(start and end):");
            int Start = Convert.ToInt32(Console.ReadLine());
            int End = Convert.ToInt32(Console.ReadLine());

            PrintPrime(Start, End);

            
        }

        public static void PrintPrime(int Start, int End)
        {
            bool[] IsPrime;
            const int MaxSize = 9999;
            IsPrime = new bool[MaxSize];
            for (int i = 0; i < MaxSize; i++)
            {
                IsPrime[i] = true;
            }
            int place = 2;
            while (place <= End)
            {
                if (IsPrime[place] && place >= Start) Console.WriteLine(place);
                int MulTimes = 2;
                while (MulTimes * place <= End)
                {
                    IsPrime[place * MulTimes] = false;
                    MulTimes++;
                }
                place++;
            }
        }
    }
}