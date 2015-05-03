using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a081DiziSiralamaYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
			{
                Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                dizi[i] = int.Parse(Console.ReadLine());
			}

            Array.Sort(dizi);

            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------");

            Array.Reverse(dizi);

            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
