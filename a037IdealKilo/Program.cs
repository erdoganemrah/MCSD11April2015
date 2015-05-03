using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a037IdealKilo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen kilonuzu kg cinsinden giriniz:");
            int Kilo = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu cm cinsinden giriniz:");
            int Boy = int.Parse(Console.ReadLine());

            int IdealKilo = Boy - 110;

            int Fark = Math.Abs(Kilo - IdealKilo);
            string Mesaj = "";

            if (Fark == 0)
            {
                Console.WriteLine("Daha iyi olamazdı. Sen ne al ne ver.");
            }
            else if (IdealKilo > Kilo)
            {
                Mesaj = String.Format("Sağlığın için biraz almalısınız. yaklaşık {0} kilo", Fark);
            }
            else
            {
                Mesaj = String.Format("Sağlığın için biraz vermelisiniz. yaklaşık {0} kilo", Fark);
            }


            Console.WriteLine(Mesaj);
            Console.ReadLine();

        }
    }
}
