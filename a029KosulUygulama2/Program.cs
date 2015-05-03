using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a029KosulUygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int T = int.Parse(Console.ReadLine());

            if (T > 10 && T < 20)
            {
                Console.WriteLine("İdeal bir sayı girdiniz. Harika....");
            }

            if (T > 100)
            {
                Console.WriteLine("Bu sayı bize pek uygun değil.....");
            }


            Console.ReadLine();

        }

    }
}
