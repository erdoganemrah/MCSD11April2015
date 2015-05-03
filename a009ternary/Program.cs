using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a009Ternary
{
    class Program
    {
        static void Main(string[] args)
        {

            int T = DateTime.Now.Hour;

            string Suffix = (T < 12) ? "am" : "pm";

            Console.WriteLine(Suffix);

            Console.ReadLine();



        }
    }
}
