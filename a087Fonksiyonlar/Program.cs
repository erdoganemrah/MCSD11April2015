using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a087Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double sonuc = f(x) + 2 * f(x);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        static double f(int x)
        {
            double sonuc = Math.Sqrt(x) + 1;
            return sonuc;
        }
    }
}
