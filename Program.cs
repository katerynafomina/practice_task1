using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
        }
        static void task1()
        {
            Console.WriteLine("введiть число:");
            string n = Console.ReadLine();
            int len = n.Length;
            int[] Array = new int[len];
            int n1 = int.Parse(n);
            for (int i = 0; i < len; i++)
            {
                int temp = n1 % 10;
                n1 /= 10;
                Array[i] = temp;
            }
            double ser_ar = Array.Average();

            Console.WriteLine($"середнє арифметичне: {ser_ar}");

        }
        static void task2()
        {
            Console.WriteLine("введiть x,y,z: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double a = (2 * Math.Sqrt(x * x + y * y)) - ((z * z * z) / 6);
            double b = 1 - Math.Sqrt(x * x + y * y);
            double c = Math.Sin((z * z * z) / 6) + Math.Cos(Math.PI / 4);
            Console.WriteLine($"a:{a}\tb:{b}\tc:{c}\nmax:{Math.Max(a, Math.Max(b, c))}");
        }
        static void task3()
        {
            const int n = 7;
            const int m = 5;
            var rand = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rand.Next(-50, 51);
                }
            }
            Console.WriteLine("матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0}\t", matrix[i, j]);
                }
                Console.WriteLine();
            }

            int[] vector_c = new int[m];

            for (int j = 0; j < m; j++)
            {
                int temp = 0;
                for (int i = 0; i < n; ++i)
                {
                    if (matrix[i, j] > 0)
                    {
                        temp += matrix[i, j];
                    }
                }
                vector_c[j] = temp;
            }
            Console.WriteLine();
            Console.WriteLine("суми додатнiх елементiв стовбцiв:");
            for (int i = 0; i < m; ++i)
            {
                Console.Write("{0}\t", vector_c[i]);
            }
            int min_vector = vector_c.Min();
            int index = 0;
            for (int i = 0; i < m; ++i)
            {
                if (min_vector == vector_c[i])
                {
                    index = i;
                }
            }
            Console.WriteLine($"\niндекс мiнiмального елемента: {index + 1}");

        }
    }
}
