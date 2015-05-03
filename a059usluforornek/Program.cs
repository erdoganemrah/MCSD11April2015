using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a059UsluForOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string Secim = "E";

            for (; Secim == "E" || Secim == "e"; )
            {
                Console.WriteLine("Lütfen 2 tane sayı giriniz:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int Sonuc = 1;

                for (int i = b; i > 0; i--)
                {
                    Sonuc *= a;

                }
                Console.WriteLine("{0} üzeri {1} = {2}", a, b, Sonuc);
                Console.WriteLine("Tekrar hesaplamak istiyor musunuz?");
                Secim = Console.ReadLine();
            }
        }
    }
}
