using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Kullanıcı bir öncekinden farklı bir sayı girdiği sürece sayıları toplayıp
Ekrana yazan, 0 girdiğinde ise işlemi sonlandıran bir uygulama hazırlayalım
*/
namespace a057DonguAtlamaOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int Onceki = 0;
            int Toplam = 0;

            while (true)
            {
                Console.Write("Sayı girin :");
                int T = int.Parse(Console.ReadLine());
                if (T == 0)
                {
                    break;
                }
                if (T == Onceki)
                {
                    continue;
                }
                Toplam += T;
                Console.WriteLine(Toplam);
                Onceki = T;
            }


            Console.WriteLine("Güle güle");
            Console.ReadLine();



        }
    }
}
