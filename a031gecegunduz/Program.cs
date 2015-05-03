using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a031GeceGunduz
{
    class Program
    {
        static void Main(string[] args)
        {

            int Saat = DateTime.Now.Hour;

            Saat = 21;

            if (Saat<6 || Saat>18)
            {
                Console.WriteLine("Gece");
            }
            else
            {
                Console.WriteLine("Gündüz");
            }

            Console.ReadLine();

        }
    }
}
