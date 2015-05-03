using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a030Else
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir sayı giriniz:");
            int T = int.Parse(Console.ReadLine());

            T += 0;

            if (T>10)
            {
                Console.WriteLine("10 dan büyük bir sayı girdiniz...");
                int K;
            }
            else
            {
                Console.WriteLine("10 dan küçük bir sayı girdiniz...");
            }

            Console.ReadLine();


        }
    }
}
