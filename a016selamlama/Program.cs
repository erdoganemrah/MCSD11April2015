using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a016Selamlama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Kullanıcıya ismini soran bir konsol uygulaması geliştirin. Kullanıcı adını yazdığında onu selamlayın.

                Örnek ekran çıktısı : 

                Lütfen İsminizi Girin :
                Yunus
                Merhaba Yunus!
             */

            Console.WriteLine("İsminiz nedir?");
            string Isim;
            Isim = Console.ReadLine();

            string Selam = "Merhaba " + Isim + "!";

            Console.WriteLine(Selam);

            Console.ReadLine();
        }
    }
}
