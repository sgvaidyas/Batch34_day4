using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class BinarySearch
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
        static void Binsearch(int[] a, int key)
        {
            int n = a.Length;
            int low, mid, high;
            low = 0;
            high = n - 1;

            while(low<=high)
            {
                mid = (low + high) / 2;
                if (a[mid] == key)
                {
                    Console.WriteLine("Search key found at pos=" + mid);
                    break;
                }
                else if (key > a[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            if(low>high)
                Console.WriteLine("Search key not found");
            
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
            Binsearch(a, key);


        }
    }
}
