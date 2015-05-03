using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kullanıcıya kaç değer girmek istediğini soralım. Sonra istediği kadar string değeri kullanıcıdan alarak depolayalım. Sonrasında yine kullanıcının istediği indise sahip değeri ekrana yazdıralım.

Kaç değer gireceksiniz?
2
1. Değeri Girin
Abc
2. Değeri Girin
DCD

Kaç numaralı deri görmek istiyorsunuz?
0
Sonuç : Abc 
 */
namespace a068DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç değer gireceksiniz?");
            int T = int.Parse(Console.ReadLine());

            string[] Dizi = new string[T];

            for (int i = 0; i < T; i++)
            {
                Console.Write("{0}. Elemanı giriniz : ", i + 1);
                Dizi[i] = Console.ReadLine();
            }

            Console.WriteLine("Kaç numaralı elemanı görmek istiyorsunuz?");

            int GorunecekIndis = int.Parse(Console.ReadLine());


            //Kullanıcı 1 girdiğinde ilk elemanı görmek ister, ilk eleman bizde 0 a karşılık geldiği için GorunecekIndis - 1 şeklinde bunu yazdık.
            Console.WriteLine(Dizi[GorunecekIndis - 1]);

            Console.ReadLine();



        }
    }
}
