using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a112Recursive
{
    class Program
    {
        // Recursive - Öz Yinelemeli Fonksiyonlar
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(4));
            Console.ReadLine();
        }

        static int Faktoriyel(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Faktoriyel(n - 1);
            }
        }
    }
}
