using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a042SwitchKurallar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Switch ifadesi bir değişkenin alabileceği sabit değerler göre çalışır. 
             * switch(Degisken_Adi) yazarız.
             * case ifadelerinde hep bir sabit bulundururuz. Karşılaştırma yapamayız.
             * Birden fazla case'de aynı iş çalışacaksa bunları alt alta yazarız. en sonra break ile sonlandırırız.
             * default ifadesi ile hiçbir case sağlanmadığında yapılacak işlemi belirlebiliriz. default kullanmak zorunda değiliz.
             * default'u istediğimiz yere yazabiliriz. Sonda olmak zorunda değildir.
             * goto case x diyerek istediğimiz bir case e atlama, sıçrama yapabiliriz.
             * goto kullandığımız zaman break kullanmamız şart değildir. 
             * goto yoksa break kullanmamız zorunludur.
             */
            int K = 5;

            Baslangic:

            Console.WriteLine("Bir sayı giriniz : ");
            K = int.Parse(Console.ReadLine());

            switch (K)
            {
                default:
                    Console.WriteLine("Default bloğu olmak zorunda değildir.");
                    break;
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    break;
                case 4:
                case 5:
                    Console.WriteLine("3,4,5");
                    break;
                case 6:
                    Console.WriteLine("Case 6 çalıştı");
                    goto case 1;    
                case 0:
                    goto Cikis;
               
            }
            goto Baslangic;
            Cikis:
            Console.WriteLine("Güle Güle...");
        }
    }
}
