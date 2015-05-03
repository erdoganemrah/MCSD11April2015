using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 Kullanıcıdan iki sayı girmesini isteyin (a,b). 
 Sonra a üzeri b değerini Math.Pow kullanmadan hesaplatın ve kullanıcıyı 
 tekrardan işlem yapmak ister misiniz? diye sorun ve eğer E ya da küçük e girerse işlemi başa döndürüp a ve b değerlerini tekrar sorarak devam edin.
 
 */
namespace a054DonguUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            string Secim = "E";

            while (Secim == "E" || Secim == "e")
            {
                Console.WriteLine("Lütfen 2 tane sayı giriniz:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int Sonuc = 1;
                int i = b;
                while (i > 0)
                {
                    Sonuc *= a;
                    i--;
                }
                Console.WriteLine("{0} üzeri {1} = {2}", a, b, Sonuc);
                Console.WriteLine("Tekrar hesaplamak istiyor musunuz?");
                Secim = Console.ReadLine();
            }

       



        }
    }
}
