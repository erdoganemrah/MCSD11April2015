using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a066ForNested3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 1)
                {
                    Console.Write(" * | ");
                    for (int m = 1; m < 10; m++)
                    {
                        Console.Write(" {0,2} ", m);
                    }

                    Console.WriteLine();

                    for (int p = 1; p < 11; p++)
                    {
                        Console.Write("----");
                    }
                    Console.WriteLine();
                }

                for (int k = 1; k < 10; k++)
                {
                    if (k == 1)
                    {
                        Console.Write("{0,2} | ", i);
                    }

                    int Carpim = i * k;
                    Console.Write(" {0,2} ", Carpim);
                }

                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
