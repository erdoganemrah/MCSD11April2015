using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a034StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string Baslangic, AraSicak, AnaYemek, Tatli;

            Baslangic = "Domates Çorbası";
            AraSicak = "Paçanga Böreği";
            AnaYemek = "Kuzu Tandır";
            Tatli = "Sütlaç / Kadayıf";

            double Ucret = 50;

            Console.WriteLine("Hoşgeldiniz menümüzde bugün {0},{1},{2},{3} var. Ayrıca tatlıyı {3} olarak seçebilirsiniz.", Baslangic,AraSicak,AnaYemek,Tatli);

            Console.WriteLine("Ödemeniz gereken ücret {0:N}, bir de {1:C} bahşiş ödeyebilirsiniz.",Ucret, Ucret * 0.1);

            string Mesaj = String.Format("Bugünün medarı iftaharı : {0}. Tatlısı {1}", AnaYemek, Tatli);

            Console.WriteLine();

            Console.WriteLine(Mesaj);

            Console.ReadLine();



        }
    }
}
