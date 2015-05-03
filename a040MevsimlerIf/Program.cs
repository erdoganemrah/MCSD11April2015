using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a040MevsimlerIf
{
    class Program
    {
        static void Main(string[] args)
        {

            //Kullanıcı 1-4 aralığında sayı girdiğinde 1 bahar 4 kış olacak şekilde ekrana mevsim ismi yazılsın.

            Console.WriteLine("1-4 aralığında sayı giriniz");

            int T = int.Parse(Console.ReadLine());

            string Mevsim = "";

            if (T == 1)
            {
                Mevsim = "İlkbahar";
            }
            else if (T == 2)
            {
                Mevsim = "Yaz";
            }
            else if (T==3)
            {
                Mevsim = "Sonbahar";
            }
            else if (T==4)
            {
                Mevsim = "Kış";
            }
            else
            {
                Mevsim = "Hatalı";
            }

            Console.WriteLine(Mevsim);
            Console.ReadLine();



        }
    }
}
