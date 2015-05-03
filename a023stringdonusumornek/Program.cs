using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a023StringDonusumOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sayi1 = 7,  Sayi2 = 1;
            string Metin1;
            string Metin2;
            Metin1 = Sayi1.ToString();
            Metin2 = Sayi2.ToString();
            string Sonuc = Metin1 + Metin2;
            Console.WriteLine(Sonuc);
            Console.ReadLine();

        }
    }
}
