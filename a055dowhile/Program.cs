using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a055DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string Secim = "";

            do
            {
                Console.WriteLine("Lütfen 2 sayı giriniz...");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int i = b;
                int Sonuc = 1;
                while (i > 0)
                {
                    Sonuc *= i;
                    i--;
                }

                Console.WriteLine(Sonuc);
                Console.WriteLine("Devam etmek istiyor musunuz? [E/H]");
                Secim = Console.ReadLine();

            } while (Secim == "E");

            Console.WriteLine("Güle güle...");

            Console.ReadLine();


        }
    }
}
