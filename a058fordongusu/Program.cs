using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a058ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            int S = 0;

            while (S < 3)
            {
                Console.WriteLine(S);
                S++;
            }

            Console.WriteLine("-------------");

            for (int sayac = 0; sayac < 3; sayac++)
            {
                Console.WriteLine(sayac);
            }


            Console.WriteLine("-------------");

            int K = 0;

            for (; K < 3; )
            {
                Console.WriteLine(K);
                K++;
            }


            Console.WriteLine("-------------");



            for (int L = 0; L < 3; L++)
            {
                Console.WriteLine(L);               
            }

            Console.ReadLine();


        }
    }
}
