using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a025ConvertUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcıdan bir int, bir double değer alıp bu değerleri toplayıp decimal bir değişkene atayarak ekranda yazdırmayı deneyiniz.

            Console.WriteLine(1 / 2D);

            Console.WriteLine("----------");


        

            Console.WriteLine("Bir tamsayı değeri girin : ");
            int TamSayi = int.Parse(Console.ReadLine());

            Console.WriteLine("Bir ondalık sayı değeri girin : ");
            string Girdi = Console.ReadLine();
            double OndalikSayi = double.Parse(Girdi);

            decimal Toplam = (decimal)(TamSayi + OndalikSayi);

            Console.WriteLine(Toplam);



            int T = int.Parse(Console.ReadLine());

            int Degisken = int.Parse(Console.ReadLine());

            int BirDegisken = int.Parse(Console.ReadLine());


            Console.ReadLine();

            Console.ReadLine();



            Console.ReadLine();



        }
    }
}
