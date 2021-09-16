using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Bubblesort
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
        static void bubbleSort(int[] a)
        {
            int i, j, temp, n;
            n = a.Length;
            for (i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter val o f n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            inputArray(a);
            outputArray(a);
            bubbleSort(a);
            Console.WriteLine("Sorted array elements");
            outputArray(a);
        }
    }
}
/*  
 n=5			0	1	2	3	4
			11	2	4	1	6
i=0	cmp=4	11	2			
	n-1		2	11	4		
	5-1-0=4			4	11	1	
					1	11	6
						6	11
i=1	cmp=3		2	4	1	6	
	n-1-i		2	4			
	5-1-1			4	1		
				1	4	6	
						6	
i=2	cmp=2		2	1	4		
	5-1-2=2		1	2	4		
					4		
							
i=3	cmp=1		1	2			
	5-1-3=1			2			

     
     */
