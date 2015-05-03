using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a067Diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad1, ad2, ad3, adn;
            int k = 10;
            string[] Adlar = new string[k];

            Adlar[0] = "Ahmet";
            Adlar[1] = "Ayşe";
            Adlar[2] = "Hafize";
            Adlar[9] = "Aa";

            string[] Mevsimler = { "Bahar", "Yaz", "Güz", "Kış" };

            string[] Seasons = new string[4];
            Seasons[0] = "Bahar";
            Seasons[1] = "Yaz";
            Seasons[2] = "Güz";
            Seasons[3] = "Kış";

            Console.WriteLine(Mevsimler[1]);
            Console.WriteLine(Seasons[1]);

            int[] Dizi = { 1, 2, 3, 4, 5, 6 };
            int[] Dizi2 = new int[12];
            Dizi2[0] = 5;

            Console.ReadLine();




        }
    }
}
