using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a102RefOrnek
{
    class Program
    {
        // ref: Bir fonksiyondan geriye birden fazla değer döndürülebilir.

        static void Main(string[] args)
        {
            var K = 12;
            Teklestir(ref K);

            Console.WriteLine(K);
            Console.ReadLine();
        }

        static void Teklestir(ref int X)
        {
            X = X + 1;
        }
    }
}
