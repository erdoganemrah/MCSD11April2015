using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  1' den 1000'e kadar olan sayılar içerisinde 5'e tam bölünen aynı zamanda
7' ye tam bölünemeyen sayıları sayan, toplamlarını hesaplayan ve bu sayıları
listeleyen bir program yazınız.

 
 */
namespace a049DonguUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 0;
            int Sayac = 0;
            int Toplam = 0;

            while (S < 1000)
            {
                if (S % 7 != 0 && S % 5 == 0)
                {
                    Sayac++;
                    Toplam += S;
                }

                S += 5;
            }

            Console.WriteLine("Toplam : {0}", Toplam);
            Console.WriteLine("Sayac : {0}", Sayac);


            Console.ReadLine();



        }
    }
}
