using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a104OutFonksiyon
{
    class Program
    {
        // ref parametrelere fonksiyonu çağıran fonksiyonun mutlaka bir ilk değer ataması gerekir.
        // ref parametrelerle fonksiyon bir işlem yapmak zorunda değildir.
        
        // out parametrelerde ilk değer ataması zorunlu değildir. out parametre alan fonksiyonun bu parametreye bir değer ataması zorunludur.
 
        static void Hesapla(int h, int a, out int alan, out int cevre)
        {
            alan = a * h / 2;
            cevre = a * 3;
        }

        static void Main(string[] args)
        {
            int a, c;
            Hesapla(5, 6, out a, out c);

            Console.WriteLine("Alan: {0}", a);
            Console.WriteLine("Çevre: {0}", c);
            Console.ReadLine();
        }
    }
}
