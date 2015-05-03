using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a010TypeOf
{
    class Program
    {
        static void Main(string[] args)
        {
            object O1 = 5;
            object O2 = "asdfasdfasdf";
            object O3 = 4.5;

            Type T = typeof(object);
        }
    }
}
