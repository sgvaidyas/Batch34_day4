using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Add2darray
    {
        static void inputArray(int[,] a)
        {
            /* Console.WriteLine();
             Console.WriteLine(a.Length);
             Console.WriteLine(a.GetLength(0));
             Console.WriteLine(a.GetLength(1));
             */
            int rows, cols;
            rows = a.GetLength(0);
            cols = a.GetLength(1);
            Console.WriteLine("Enter array elements = ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static void displayArray(int[,] a)
        {
            int rows, cols;
            rows = a.GetLength(0);
            cols = a.GetLength(1);
            Console.WriteLine("\nThe array elements = ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }
        }
        static void add(int[,] a,int[,] b,int[,] c)
        {
            int rows, cols;
            rows = a.GetLength(0);
            cols = a.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
        }
        static void Main(string[] args)
        {
            int rows, cols;
            Console.WriteLine("Enter rows and cols");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[rows, cols];
            int[,] b = new int[rows, cols];
            int[,] c = new int[rows, cols];
            inputArray(a);
            inputArray(b);
            add(a, b, c);
            displayArray(a);
            displayArray(b);
            displayArray(c);
        }
    }
}
