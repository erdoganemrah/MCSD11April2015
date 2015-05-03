using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a056DoWhileMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            string Secim = "";
            do
            {
                Console.WriteLine("-> Menü [M] ");
                Console.WriteLine("-> Yenile [Y]");
                Console.WriteLine("-> Çıkış [Q] ");
                Console.Write("Lütfen seçiminizi yapın : ");
                Secim = Console.ReadLine();

            } while (Secim != "Q");

            Console.WriteLine("Güle güle....");
            Console.ReadLine();

        }
    }
}
