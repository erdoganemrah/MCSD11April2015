using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a108OverloadOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Yaz("Selamlar");
            Yaz(10);
            Yaz("Naber?", 8);

            Console.ReadLine();
        }

        /// <summary>
        /// Verdiğiniz ifadeyi yazar.
        /// </summary>
        /// <param name="deger"></param>
        static void Yaz(string deger)
        {
            Console.WriteLine(deger);
        }

        /// <summary>
        /// Verdiğiniz sayı kadar ekrana Merhaba yazar.
        /// </summary>
        /// <param name="sayi">Kaç kez yazdırılacak</param>
        static void Yaz(int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Merhaba");
            }
        }

        /// <summary>
        /// Verdiğiniz sayıda değeri ekrana yazar.
        /// </summary>
        /// <param name="deger">Yazdırılacak olan değer</param>
        /// <param name="sayi">Kaç kez yazılacak</param>
        static void Yaz(string deger, int sayi)
        {
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(deger);
            }
        }
    }
}
