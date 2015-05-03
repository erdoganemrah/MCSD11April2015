using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a111ParamsOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            var mi = IsimBul("Ahmet", "Mehmet", "Fatma", "Ahmet", "Veli", "Bekir");
            if (mi)
            {
                Console.WriteLine("Var");
            }
            else
            {
                Console.WriteLine("Yok!");
            }

            Console.ReadLine();
        }

        static bool IsimBul(string aranan, params string[] kullaniciAdlari)
        {
            return kullaniciAdlari.Contains(aranan);
        }
    }
}
