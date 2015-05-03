using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kullanıcıdan bir sayı girmesini isteyin ve bu sayının asal olup olmadığını kullanıcıya söyleyin.
 
 */
namespace a051AsalUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz....");

            int T = int.Parse(Console.ReadLine());

            bool Asal = true;

            int Bolen = 2;

            while (Bolen < T)
            {
                if (T % Bolen == 0)
                {
                    Asal = false;
                    break;
                }
                Bolen++;
            }

            if (T < 2)
            {
                Asal = false;
            }


            string Mesaj = Asal ? "Sayı asaldır." : "Asal değildir.";

            Console.WriteLine(Mesaj);

            Console.ReadLine();




        }
    }
}
