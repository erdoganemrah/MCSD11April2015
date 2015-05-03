using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Gunler isminde bir dizi değişken tanımlayın, kullanıcının gireceği rakama karşılık gelen gün adını ekrana yazdırın. Herhangi bir if ya da switch yapısı kullanmasızın bu çalışmayı yapabilmeniz gerekir.

 
 */
namespace a066DiziUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı girin [1-7]: ");
            int T = int.Parse(Console.ReadLine());

            string[] Days = new string[50];

            string[] Gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            T--;

            string SecilenGun = Gunler[T];

            Console.WriteLine(SecilenGun);
            Console.ReadLine();



        }
    }
}
