using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a080SonsuzDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();

            while (true)
            {
                int r = rastgele.Next(1, 1000);
                Console.WriteLine(r);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
