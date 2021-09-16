using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Paramex1
    {
        static int myfun(params int[] val)
        {
            int sum = 0;
            foreach (int x in val)
                sum += x;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("First ex");
            Console.WriteLine(myfun(2, 3, 44, 5, 6, 7));

            Console.WriteLine("First ex2");
            Console.WriteLine(myfun(2, 3, 44));
        }
    }
}
