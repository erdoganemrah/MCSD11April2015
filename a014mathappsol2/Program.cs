using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a014MathAppSol2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz : ");
            int x = int.Parse(Console.ReadLine());

            double Sonuc = Math.Pow(x, 3) - 5;
            Sonuc = Sonuc + Math.Pow(x, 1 / 3D);
            Sonuc /= x + 7;

            Console.WriteLine(Sonuc);
            Console.ReadLine();
        }
    }
}
