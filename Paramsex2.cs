using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch34_day4
{
    class Paramsex2
    {
        static void myfun(params object[] val)
        {
            foreach(object a in val)
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            myfun("shilpa", 88, 9.7, 'h');
        }
    }
}
