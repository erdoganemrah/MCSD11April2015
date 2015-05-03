using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kullanıcıdan iki tane sayı alan ve bu iki sayının arasındaki 
 çift sayıları ekrana yazan konsol uygulamasını geliştiriniz.
 
 */
namespace a050DonguSayiUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen iki sayı giriniz.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int Baslangic = a;
            int Bitis = b;

            if (b < a)
            {
                Baslangic = b;
                Bitis = a;
            }

            int S = Baslangic;

            while (S <= Bitis)
            {
                if (S%2==0)
                {
                    Console.WriteLine(S);
                }

                S++;
            }

            Console.ReadLine();


        }
    }
}
