using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a032ElseIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen yaşadığınız yerdeki saati giriniz:");
            int T = int.Parse(Console.ReadLine());

            if (T > 7 && T < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if (T >= 11 && T <= 18)
            {
                Console.WriteLine("İyi günler");
            }
            else if (T >= 18 && T < 21)
            {
                Console.WriteLine("İyi akşamlar");
            }
            else
            {
                Console.WriteLine("İyi geceler... Tatlı rüyalar...");
            }

            Console.ReadLine();



        }
    }
}
