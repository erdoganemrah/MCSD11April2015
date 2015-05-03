using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a078CiftSayiYuzdesi
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciftElemanSayisi = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
                int t = int.Parse(Console.ReadLine());

                if (t % 2 == 0)
                {
                    ciftElemanSayisi++;
                }
            }

            double yuzde = ciftElemanSayisi / 6D * 100;
            Console.WriteLine("%{0} Çift sayı girdiniz", yuzde);
            Console.ReadLine();
        }
    }
}
