using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a114Enum
{
    enum MevsimTipi
    {
        Ilkbahar = 1,
        Yaz = 2,
        Sonbahar = 3,
        Kış = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            MevsimTipi mt = MevsimTipi.Yaz;
            int num = (int)mt;

            mt = (MevsimTipi)6;

            Console.WriteLine(mt);
            Console.ReadLine();
        }
    }
}
