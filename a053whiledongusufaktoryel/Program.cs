using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  6! = 6*5*4*3*2

Kullanıcının gireceği bir sayının faktöryel değerini hesaplayan 
while uygulamasını hazırlayınız.
 
 */
namespace a053WhileDongusuFaktoryel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int T = int.Parse(Console.ReadLine());
            int i = 1;
            int Faktoryel = 1;

            while (i <= T)
            {
                Faktoryel *= i;
                i++;
            }

            Console.WriteLine("{0}! = {1}", T, Faktoryel);

            Console.ReadLine();




        }
    }
}
