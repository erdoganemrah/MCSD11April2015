using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a076ZamanDongu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int saniye = DateTime.Now.Second;

                Console.WriteLine("Saniye: {0}" , saniye);

                if (saniye % 30 == 0)
                {
                    break;
                }                
            }
            Console.ReadLine();
        }
    }
}
