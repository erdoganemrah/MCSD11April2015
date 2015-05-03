using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a043SwitchKahve
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen kahve taban fiyatını giriniz");

            double Fiyat = double.Parse(Console.ReadLine());

            Console.WriteLine("Lürfen kahvenin boyutunu [K]üçük, [O]rta, [B]üyük girin");

            string Boyut = Console.ReadLine();

            double OdenecekTutar = 0;

            switch (Boyut)
            {
                case "K":
                case "k":
                    OdenecekTutar = Fiyat;
                    break;
                case "O":
                case "o":
                    OdenecekTutar = Fiyat * 1.25;
                    break;
                case "B":
                case "b":
                    OdenecekTutar = Fiyat * 1.50;
                    break;
                default:
                    OdenecekTutar = 0;
                    Console.WriteLine("Hatalı giriş");
                    break;
            }

            Console.WriteLine("Ödenmesi gereken tutar : {0:N}",OdenecekTutar);
            Console.ReadLine();


        }
    }
}
