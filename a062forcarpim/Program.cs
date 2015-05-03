using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 
 Verilen sayının 1 den 9 a kadar bütün çarpım değerlerini ekrana yazdıracak uygulamayı hazırlayınız.
Sayı Girin : 3
3 x 1 = 3
3 x 2 = 6 
3 x 3 = 9 
......
3 x 9 = 27
 
 */
namespace a062ForCarpim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int T = int.Parse(Console.ReadLine());
            int Carpim = 0;

            for (int i = 1; i <= 10; i++)
            {
                Carpim = i * T;

                Console.WriteLine("{0} X {1,2} = {2}", T, i, Carpim);

                
            }

            Console.ReadLine();

        }
    }
}
