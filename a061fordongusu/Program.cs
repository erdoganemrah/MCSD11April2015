using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Kullanıcı iki sayı girdiğinde o aralıktaki sayılara karşılık gelen bütün karaketerleri for döngüsü kullanarak ekrana yazıdınız.

Console.Write(c);
Console.Write(",");

 */
namespace a061ForDongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lütfen başlangıç sayısını giriniz.");

            int a = int.Parse(Console.ReadLine());

            Console.Write("Lütfen bitiş sayısını giriniz.");

            int b = int.Parse(Console.ReadLine());

            for (int i = a; i < b; i++)
            {

                char c = (char)i;
                Console.Write("{0} -> ", i);
                Console.Write(c);
                Console.Write(",");
                Console.WriteLine();


            }

            Console.ReadLine();

        }
    }
}
