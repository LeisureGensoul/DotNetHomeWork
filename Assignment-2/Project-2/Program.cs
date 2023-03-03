using System;
using System.Data.Common;

namespace Matrix
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            int[] Array;
            const int MaxSize = 1024;
            Array = new int[MaxSize];
            Console.WriteLine("Enter The Size of the Array(<1024):");
            int ArraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The Number(one line):");
            string? ArrayData = Console.ReadLine();//首先输入一字符串，表示二维数组的一行数据
            if (ArrayData == null)
            {
                Console.WriteLine("We need datas");
                return;
            }
            string[] tmp = ArrayData.Split(" ".ToCharArray());//通过Split方法以空格作为分隔符将输入的一行字符串分隔开
            for (int TemPlace = 1; TemPlace <= ArraySize; TemPlace++)
            {
                Array[TemPlace] = int.Parse(tmp[TemPlace - 1]);//将分割后的字符付给二维数组每个元素
            }
            /*for (int TemPlace = 1; TemPlace <= ArraySize; TemPlace++)
            {
                Console.WriteLine(Array[TemPlace]);
            }*/

            PrintFeatures(Array, ArraySize);
        }

        public static void PrintFeatures(int[] Array, int ArraySize)
        {
            int Maxx = 0, Minn = 0xfffff, Sum = 0;
            double Average = 0;

            int place = ArraySize;
            while (place != 0)
            {
                if (Array[place] > Maxx)
                {
                    Maxx = Array[place];
                }
                if (Array[place] < Minn)
                {
                    Minn = Array[place];
                }
                Sum += Array[place];
                Average += Array[place];
                place--;
            }
            Average = Average / ArraySize;

            Console.WriteLine("The Max ArraySize is " + Maxx);
            Console.WriteLine("The Min ArraySize is " + Minn);
            Console.WriteLine("The Sum is " + Sum);
            Console.WriteLine("The Average is " + Average);
        }
    }
}