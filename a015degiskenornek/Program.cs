using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a015DegiskenOrnek
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             . Bir C# konsol uygulaması geliştirin ve 2 adet int, bir float, 
             * bir de string değişken tanımlayın. Bu değişkenlere sırasıyla 
             * 5,12, 1.8, "C# ile Hayat Güzel" değerlerini atayın. Her bir değişkenin değirini ekrana yazdırın.

             */

            int Tamsayi1, Tamsayi2;
            float Ondalik;
            string Metin;

            Tamsayi1 = 5;
            Tamsayi2 = 12;
            Ondalik = 1.8F;
            Metin = "C# ile Hayat Güzel";

            Console.WriteLine(Tamsayi1);
            Console.WriteLine(Tamsayi2);
            Console.WriteLine(Ondalik);
            Console.WriteLine(Metin);

            Console.ReadLine();
        }
    }
}
