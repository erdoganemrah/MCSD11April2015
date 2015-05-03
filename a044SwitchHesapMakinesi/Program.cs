using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a044SwitchHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
        Baslangic:
            Console.Clear();

            Console.WriteLine("Birinci sayıyı girin");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Operatörü girin");
            string Op = Console.ReadLine();
            Console.WriteLine("İkinci sayıyı girin");
            double y = double.Parse(Console.ReadLine());
            double Sonuc = 0;

            switch (Op)
            {
                case "+":
                    Sonuc = x + y;
                    break;
                case "-":
                    Sonuc = x - y;
                    break;
                case "/":
                    Sonuc = x / y;
                    break;
                case "*":
                    Sonuc = x * y;
                    break;
                default:
                    Console.WriteLine("Hatalı seçim...");
                    break;
            }

            Console.WriteLine("Sonuc : {0}",Sonuc);
            Console.ReadLine();
            goto Baslangic;

        }
    }
}
