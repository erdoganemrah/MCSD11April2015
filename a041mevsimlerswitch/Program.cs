using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a041MevsimlerSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-4 aralığında sayı giriniz");

            int T = int.Parse(Console.ReadLine());

            string Mevsim = "";

            switch (T)
            {
                case 1:
                    Mevsim = "Bahar";
                    break;
                case 2:
                    Mevsim = "Yaz";
                    break;
                case 3:
                    Mevsim = "Güz";
                    break;
                case 4:
                    Mevsim = "Kış";
                    break;
                default:
                    Mevsim = "Hatalı";
                    break;
            }

            Console.WriteLine(Mevsim);
            Console.ReadLine();




        }
    }
}
