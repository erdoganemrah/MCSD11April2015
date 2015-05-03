using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1
//22
//333
//4444
//55555

//Şeklinde bir çıktıyı verecek programı hazırlayınız. Bitiş değerini kullanıcı girecektir.

namespace a063ForNested1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz:");
            int T = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= T; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
