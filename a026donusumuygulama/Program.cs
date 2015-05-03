using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a026DonusumUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 3 adet ondalık sayı giriniz.");

            decimal D1 = decimal.Parse(Console.ReadLine());
            decimal D2 = decimal.Parse(Console.ReadLine());
            decimal D3 = decimal.Parse(Console.ReadLine());

            string T = D1.ToString() + D2.ToString() + D3.ToString();

            Console.WriteLine(T);

            Console.ReadLine();


        }
    }
}
