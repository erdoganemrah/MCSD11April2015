using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a035HarfNotu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 0 - 100 aralığında öğrenci notunu giriniz: ");
            int SayisalNotu = int.Parse(Console.ReadLine());
            char HarfNotu = 'N';

            if (SayisalNotu < 0 || SayisalNotu > 100)
            {
                Console.WriteLine("Bu işlem geçersizdir.");
            }
            else if (SayisalNotu >= 90)
            {
                HarfNotu = 'A';
            }
            else if (SayisalNotu >= 80)
            {
                HarfNotu = 'B';
            }
            else if (SayisalNotu >= 70)
            {
                HarfNotu = 'C';
            }
            else if (SayisalNotu >= 60)
            {
                HarfNotu = 'D';
            }
            else
            {
                HarfNotu = 'F';
            }


            if (HarfNotu == 'N')
            {
                Console.WriteLine("Bir dahaya 0-100 aralığında bir değer girin...");
            }
            else
            {
                Console.WriteLine("Öğrencinin harf notu : {0}", HarfNotu);
            }

            Console.ReadLine();




        }
    }
}
