using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a103RefUygulama
{
    class Program
    {
        static void ToplaCikar(int a, int b, ref int Fark, ref int Toplam)
        {
            Fark = a - b;
            Toplam = a + b;
        }

        static void Main(string[] args)
        {
            int f = 0, t = 0;
            ToplaCikar(12, 6, ref f, ref t);
            Console.WriteLine("{0} {1}",f, t);
            Console.ReadLine();
        }
    }
}
