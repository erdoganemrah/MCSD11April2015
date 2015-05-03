using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kullanıcıdan 10 tane not girmesini isteyin. Bu 10 notun en büyüğünü, en küçüğünü ve ortalamasını bularak ekrana yazdırın.
 
 */
namespace a052NotlarDongu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen 10 adet not girin.");

            int Sayac = 10;

            int Toplam = 0;
            int EnBuyuk = 0;
            int EnKucuk = 100;

            while (Sayac > 0)
            {
                Console.Write("{0}. Notu Giriniz : ",Sayac);
                int Not = int.Parse(Console.ReadLine());
                if (Not>EnBuyuk)
                {
                    EnBuyuk = Not;
                }

                if (Not < EnKucuk)
                {
                    EnKucuk = Not;
                }

                Toplam += Not;
                Sayac--;
            }


            Console.WriteLine("Girdiğiniz notların en küçüğü {0}", EnKucuk);
            Console.WriteLine("Girdiğiniz notların en büyüğü {0}", EnBuyuk);
            Console.WriteLine("Girdiğiniz notların ortalaması {0}", Toplam / 10);

            Console.ReadLine();



        }
    }
}
