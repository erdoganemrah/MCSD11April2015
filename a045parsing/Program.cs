using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a045Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir tamsayı girin");
            //int S = int.Parse(Console.ReadLine());
            //double T = double.Parse(Console.ReadLine());
            //int K = (int)T;

            byte B = byte.Parse(Console.ReadLine());
            string Mesaj="";
            if (B < 10)
            {
               Mesaj = "Tek basamak";
            }
            else if( B<100)
            {
                Mesaj = "İki basamak";
            }
            else
            {
                Mesaj = "Üç basamaklıdır.";
            }

            Console.WriteLine(Mesaj);
            Console.ReadLine();

        }
    }
}
