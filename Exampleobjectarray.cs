using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Exampleobjectarray
    {
        static void myfun(params object[] rec)
        {
            Console.WriteLine("_________________________");
            foreach(object x in rec)
              Console.WriteLine(x);
            Console.WriteLine("_________________________");
        }
        static void Main(string[] args)
        {
            string name, desig;
            int age,ch;
            do
            {
                Console.WriteLine("Enter the name = ");
                name = Console.ReadLine();
                Console.WriteLine("Enter the desig = ");
                desig = Console.ReadLine();
                Console.WriteLine("Enter the age = ");
                age = Convert.ToInt32(Console.ReadLine());
                myfun(name, desig, age);
                Console.WriteLine("whether you want to quit Press 1");
                ch = Convert.ToInt32(Console.ReadLine());
            } while (ch != 1);
        }
    }
}
