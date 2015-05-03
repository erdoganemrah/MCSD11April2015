using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a085DonguUcgen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Driven Development

            Console.Write("Üçgen genişliğini girin:");
            int t = int.Parse(Console.ReadLine());

            int adim = 1;

            string bir = new String('*', 5);

            for (int i = 1; i > 0; i += adim)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                if (i == t)
                {
                    adim = -1;
                }
            }

            Console.ReadLine();
        }
    }
}
