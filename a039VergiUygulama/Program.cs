using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a039VergiUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen gelir tutarınızı giriniz : ");
            double Gelir = double.Parse(Console.ReadLine());

            double Taban = 0;
            double Artan = 0;
            double Oran = 0;

            if (Gelir < 11000)
            {
                Artan = Gelir;
                Oran = 15;
            }
            else if (Gelir < 27000)
            {
                Artan = Gelir - 11000;
                Taban = 1650;
                Oran = 20;
            }
            else if(Gelir < 60000)
            {
                Artan = Gelir - 27000;
                Taban = 4850;
                Oran = 27;
            }
            else
            {
                Artan = Gelir - 60000;
                Taban = 13760;
                Oran = 35;
            }

            double Vergi = Taban + (Artan * Oran / 100);
            Console.WriteLine("Ödemeniz gereken vergi : {0:N}", Vergi);
            Console.WriteLine("Net Elegeçen : {0:N}", Gelir - Vergi);

            Console.ReadLine();

           

        }
    }
}
