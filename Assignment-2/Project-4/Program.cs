using System;

namespace TEMP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the m,n of the matrix:");
            int Row = Convert.ToInt32(Console.ReadLine());
            int Column = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the data of the matrix：");
            int[,] Matrix = new int[Row + 1, Column + 1];

            for (int i = 1; i <= Row; i++)
            {
                string? str = Console.ReadLine();//首先输入一字符串，表示二维数组的一行数据
                if (str == null)
                {
                    Console.WriteLine("We need more rows");
                    break;
                }
                string[] tmp = str.Split(" ".ToCharArray());//通过Split方法以空格作为分隔符将输入的一行字符串分隔开
                for (int j = 1; j <= Column; j++)
                {
                    Matrix[i, j] = int.Parse(tmp[j-1]);//将分割后的字符付给二维数组每个元素
                }
            }

            bool check = CheckMatrix(Matrix, Row, Column);
            if (check)
            {
                Console.WriteLine("yes, it is!");
            }
            else { Console.WriteLine("No, it isn't!"); }

            //Console.WriteLine("二维数组为：");
            //输出二维数组
            /*for (int i = 1; i <= Row; i++)
            {
                for (int j = 1; j <= Column; j++)
                    Console.Write(Matrix[i, j] + " ");
                Console.WriteLine();
            }*/
        }
        public static bool CheckMatrix(int[,] Matrix, int Row, int Column)
        {
            bool check = true;
            int place = 1, record = 0;
            record = Matrix[1, 1];
            while (true) 
            {
                place++;
                if (place > Row || place > Column) break;
                if (record != Matrix[place, place])
                {
                    check = false;
                }
                record = Matrix[place, place];
            }
            return check;
        }
    }

}