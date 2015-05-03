using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a106RefOutUygulama
{
    class Program
    {
        static void CarpBol(int deger1, int deger2, out int carpim, out int bolum)
        {
            carpim = deger1 * deger2;
            bolum = deger2 != 0 ? deger1 / deger2 : 0;
        }

        static void ToplaCikar(int deger1, int deger2, ref int toplam, ref int fark)
        {
            toplam = deger1 + deger2;
            fark = deger1 - deger2;
        }

        static int Toplam(int deger1, int deger2, ref int toplam2)
        {
            toplam2 = deger1 + deger2 + 18;
            return 0;
        }

        static void Main(string[] args)
        {
            int t = 0, f = 0, c, b;
            ToplaCikar(96, 32, ref t, ref f);
            CarpBol(12, 4, out c, out b);

            Console.WriteLine("Toplam: {0}, Fark: {1}, Çarpım: {2}, Bölüm: {3}", t, f, c, b);
            Console.ReadLine();
        }
    }
}
