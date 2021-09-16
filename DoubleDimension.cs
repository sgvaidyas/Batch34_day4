using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class DoubleDimension
    {
        static void Main(string[] args)
        {
            int rows, cols;
            Console.WriteLine("Enter rows and cols");
            rows = Convert.ToInt32(Console.ReadLine());
            cols = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[rows,cols];

            Console.WriteLine("Enter array elements = ");
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The array elements = ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
