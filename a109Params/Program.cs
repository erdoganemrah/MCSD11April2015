using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a109Params
{
    class Program
    {
        // Sonsuz sayıda parametre alan bir method yazmak istiyorum.
        // Eğer bir fonksiyonda params olacaksa en son parametre olmak zorunda.

        static void Main(string[] args)
        {
            int enBuyukDeger = EnBuyukBul(889,546,3,41,1049,58,5);
            Console.WriteLine(enBuyukDeger);
            Console.ReadLine();
        }

        private static int EnBuyukBul(params int[] sayiDizisi)
        {
            int enBuyuk = int.MinValue;

            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                if (sayiDizisi[i] > enBuyuk)
                {
                    enBuyuk = sayiDizisi[i];
                }
            }

            return enBuyuk;
        }
    }
}
