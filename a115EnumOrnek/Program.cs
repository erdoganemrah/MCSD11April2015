using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a115EnumOrnek
{
    class Program
    {
        enum Cinsiyet
        {
            Erkek,
            Kadin
        }

        static void Main(string[] args)
        {
            Cinsiyet c = Cinsiyet.Erkek;

            Console.WriteLine("Cinsiyetiniz:");
            string cins = Console.ReadLine();

            // typeof, parametre olarak eğer bir tip kullanılacaksa kullanımlalıdır.
            c = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cins);

            Console.WriteLine(c);

            Console.WriteLine(c.ToString());

            string[] degerler = Enum.GetNames(typeof(Cinsiyet));

            Console.ReadLine();
        }
    }
}
