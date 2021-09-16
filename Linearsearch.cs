using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Linearsearch
    {
        static void inputArray(int[] a)
        {
            int n = a.Length;

            Console.WriteLine("Enter array elements =");
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
        }
        static void outputArray(int[] a)
        {
            int n = a.Length;

            Console.WriteLine("\narray elements =");
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + "\t");
            Console.WriteLine();
        }
        static void linearsearch(int[] a, int key)
        {
            int n = a.Length;
            int count = 0;
            for(int i=0;i<n;i++)
            {
                if(a[i]==key)
                {
                    count++;
                    Console.WriteLine("Search key is found at ind="+i);
                }
            }
            if(count==0)
                Console.WriteLine("Search key is not found");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter val o f n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            inputArray(a);
            outputArray(a);

            Console.WriteLine("Enter search key");
            int key = Convert.ToInt32(Console.ReadLine());
            linearsearch(a, key);

        }
    }
}
