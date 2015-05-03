using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a028KosulUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir ondalık sayı giriniz");

            double T = double.Parse(Console.ReadLine());

            int Y;

            Y = (int)T;

            if (Y==T)
            {
                Console.WriteLine("Girdiğiniz sayı aynı zamanda bir tamsayı");
            }

            if (false)
            {
                Console.WriteLine("Daima çalışırım....");
            }

            Console.WriteLine("Teşekkürler");
            Console.ReadLine();
        }
    }
}
