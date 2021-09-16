using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class JaggedArrays
    {
        static void Main(string[] args)
        {
            int rows;
            Console.WriteLine("Enter rows = ");
            rows = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[rows][];
            int col;
            
            for (int i=0;i<a.GetLength(0);i++)
            {
                Console.WriteLine("enter the col = ");
                col = Convert.ToInt32(Console.ReadLine());
                a[i] = new int[col];
            }
            Console.WriteLine("\nEnter array elements");
            for(int i = 0; i < a.GetLength(0); i++)
            {
                col = a[i].Length;
                Console.WriteLine("Enter "+col+" elements");
                for (int j = 0; j < col; j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n array elements");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                col = a[i].Length;
                
                for (int j = 0; j < col; j++)
                {
                    Console.Write(  a[i][j] +"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
