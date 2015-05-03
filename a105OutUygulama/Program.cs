using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a105OutUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");

            int t;

            string girdi = Console.ReadLine();

            bool gecerliMi = int.TryParse(girdi, out t);

            if (gecerliMi)
            {
                Console.WriteLine(t);
            }
            else
            {
                Console.WriteLine("Geçersiz bir değer girdiniz.");
            }

            Console.ReadLine();
        }
    }
}
