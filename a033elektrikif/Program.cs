using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a033ElektrikIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen elektrik tüketim miktarınızı KW cinsinden giriniz....");

            int T = int.Parse(Console.ReadLine());

            int BirimFiyat = 0;

            if (T<0)
            {
                Console.WriteLine("Böyle tüketim olmaz....");
            }
            else if (T<=150)
            {
                BirimFiyat = 10;               
            }
            else if (T<=300)
            {
                BirimFiyat = 20;
            }
            else
            {
                BirimFiyat = 40;
            }

            double Tutar = BirimFiyat * T;

            Console.WriteLine("Tüketiminiz {0}, Birim Fiyat : {1:N}, Ödemeniz gereken toplam tutar : {2:C}", T,BirimFiyat,Tutar);

            Console.ReadLine();




        }
    }
}
