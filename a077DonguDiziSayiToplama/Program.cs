using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a077DonguDiziSayiToplama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i + 1);
                int girilenDeger = int.Parse(Console.ReadLine());
                dizi[i] = girilenDeger;
            }

            int tekSayilarinToplami = 0;

            foreach (int item in dizi)
            {
                if (item % 2 == 1)
                {
                    tekSayilarinToplami += item;
                }
            }

            Console.WriteLine("Girdiğiniz sayılardan tek olanların toplamı {0}", tekSayilarinToplami);

            Console.ReadLine();
        }
    }
}
