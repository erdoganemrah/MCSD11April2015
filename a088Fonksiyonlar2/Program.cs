using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a088Fonksiyonlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpılacak değerleri giriniz:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Sonuç: {0}", Carpma(a, b));
            Console.ReadLine();
        }

        // Toplama işlemini yapacak kodu Topla adı altında bir fonksiyona yerleştirdik, a ve b fonksiyonun parametreleri, topla fonksiyonun adı int de geri dönüş değeridir.

        /*
         * Fonksiyonlara isim verirken değişken adlandırma kurallarına uyarız.
         * Noktalama işaretleri kullanamaz, sayı ile başlayamaz vs.
         * Fonksiyona mutlaka bir geri dönüş tipi yazılır. Burada geri dönüş değeri double'dır.
         * Fonksiyona hiç ya da birden fazla parametre verilebilir. Burada a ve b fonksiyonun parametreleridir.
         * Her parametrenin tipi ayrı ayrı bildirilmelidir. int a,b tanımlanamaz.
         * Fonksiyonları hangi sırada yazdığımızın bir önemi yoktur. Çağırılma sıralarına göre çalışırlar.
         * return ifadesi fonksiyonu sonlandırır. return ifadesinden sonra yazacağımız kodlar çalışmayacaktır. Birden fazla return ifadesi kullanmamız mümkündür. return ifadesini fonksiyonlarda sanki break gibi kullanabiliriz.
         * Fonksiyonlar parametre almasa dahi paranter yazılır.
         */

        static double Topla(int a, int b = 5)
        {
            if (a == 0 && b == 0)
            {
                return 0;
            }
            else
            {
                return a + b;
            }
        }

        static int Carpma(int ilkDeger, int ikinciDeger)
        {
            return ilkDeger * ikinciDeger;
        }
    }
}
