using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a019MatematikIslemler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Kullanıcıdan bir sayı girmesini isteyiniz. 
             * Girdiği sayının karesini,kare kökünü ve 10 ile bölümünden kalanı 
             * ekranda yazdırınız.
             */
            Console.WriteLine("Lütfen bir tam sayı giriniz:");
            int Sayi = int.Parse(Console.ReadLine());

            double Karesi = Math.Pow(Sayi, 2);
            double Koku = Math.Sqrt(Sayi);
            double Kalan = Sayi % 10;

            Console.WriteLine("Karesi : " + Karesi);
            Console.WriteLine("Kare Kökü : " + Koku);
            Console.WriteLine("10 ile bölümünden Kalan : " + Kalan);

            Console.ReadLine();




        }
    }
}
