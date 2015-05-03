using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Random Rnd = new Random();
Rnd.Next(1, 100);//1 ile 100 arasında rastgele bir sayı....           

40 Elemanlı bir int[] dizi tanımlayıp tüm elemanlarını rastgele sayılarla doldurun. Sonra kullanıcı aralık dışında bir değer girene kadar istediği indisteki elemanları ekrana yazdırın.



 
 */
namespace a069DiziRastgeleEleman
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Dizi = new int[40];

            Random Rnd = new Random();

            for (int i = 0; i < 40; i++)
            {
                Dizi[i] = Rnd.Next(1, 100);
            }

            for (; ; )
            {
                Console.WriteLine("Kaç numaralı elemanı görmek istiyorsunuz?");
                int T = int.Parse(Console.ReadLine());

                if (T < 0 || T >= 40)
                {
                    break;
                }

                int Eleman = Dizi[T];
                Console.WriteLine("{0}. Elemanın değeri : {1}", T, Eleman);
            }

            Console.WriteLine("Güle güle....");
            Console.ReadLine();


        }
    }
}
