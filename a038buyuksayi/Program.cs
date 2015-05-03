using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a038BuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 3 tane sayı giriniz : ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int Enbuyuk = x;
            if (y > Enbuyuk)
            {
                Enbuyuk = y;
            }
            if (z > Enbuyuk)
            {
                Enbuyuk = z;
            }
            Console.WriteLine("Girdiğiniz sayıların en büyüğü : {0}", Enbuyuk);
            Console.ReadLine();




        }
    }
}
