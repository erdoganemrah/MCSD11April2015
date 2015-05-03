using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a071Contains
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Dizi = { "Jale", "Semiha", "Mehmet", "Kamil", "Lale", "Cabbar", "Murtaza" };

            Console.WriteLine("Kimi aramıştınız?");

            string Aranan = Console.ReadLine();

            bool VarMi = Dizi.Contains(Aranan);

            

            Console.WriteLine(VarMi ? "Kişi var" : "Kişi yok");

            string TC = DateTime.Now.Second % 2 == 1 ? "TEK" : "ÇİFT";

            Console.ReadLine();


        }
    }
}
