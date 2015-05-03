using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kullanıcı satir ve sütün sayısı girecek, girilen satır ve sütunların sayısınca ekrana * karakteri yazdırılacaktır
//                  Örneğin kullanıcı satir olarak 3 sütun olarak 5 girerse ekranda:
//                  *****
//                  *****
//                  *****

namespace a064NestedFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Satır sayısını giriniz");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütun sayısını girin");
            int x = int.Parse(Console.ReadLine());


            for (int i = 0; i < y; i++)
            {
                for (int k = 0; k < x; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
