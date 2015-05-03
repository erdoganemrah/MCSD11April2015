using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a013MathAppSol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");

            int x = int.Parse(Console.ReadLine());

            double S = (x * x + 5 * x) + 8;
            double x3 = Math.Pow(x, 3);
            S = S / Math.Abs(x3 - 17);
            Console.WriteLine("Sonuç : " + S);

            Console.ReadLine();
        }
    }
}
