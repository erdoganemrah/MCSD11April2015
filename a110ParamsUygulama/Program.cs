using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a110ParamsUygulama
{
    class Program
    {
        // Sonsuz sayıda tam sayı değeri alan ve bu tam sayı değerlerinin ortalamasını geriye döndüren fonksiyonu hazırlayınız.

        static void Main(string[] args)
        {
            int ortalama = OrtalamaDegeriBul(5, 8, 14, 36, 25, 82, 74, 96, 31, 556, 74, 45, 17, 99);
            Console.WriteLine(ortalama);
            Console.ReadLine();
        }

        static int OrtalamaDegeriBul(params int[] girilenDegerler)
        {
            int toplam = 0, sonuc;

            for (int i = 0; i < girilenDegerler.Length; i++)
            {
                toplam += girilenDegerler[i];
            }

            sonuc = toplam / girilenDegerler.Length;

            return sonuc;
        }
    }
}
