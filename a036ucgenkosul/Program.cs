using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a036UcgenKosul
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lütfen bir üçgene ait her bir kenarın uzunluğunu giriniz.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            string UcgenTipi = "";
            bool Cizilebilir = true;

            if (a == b && b == c)
            {
                UcgenTipi = "Eşkenar";
            }
            else if (a == b || a == c || b == c)
            {
                UcgenTipi = "İkizkenar";
            }
            else
            {
                UcgenTipi = "Çeşitkenar";
            }


            if (a + b <= c || Math.Abs(a - b) >= c)
            {
                Cizilebilir = false;
            }

            if (Cizilebilir)
            {
                Console.WriteLine("Ayrıtlarını girmiş olduğunuz üçgen bir {0} üçgendir.",UcgenTipi);
            }
            else
            {
                Console.WriteLine("Üçgen çizilemez...");
            }

            Console.ReadLine();

            int boy = 0;
            int kilo = boy - ((150-boy)/4)+110;


        }
    }
}
