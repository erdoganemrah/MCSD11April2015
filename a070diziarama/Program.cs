using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Toplam 7 elemanı bulunana bir string dizi tanımlayın ve istediğiniz değerleri verin.
 string[] Dizi = {"Jale","Semiha","Mehmet","Kamil"}
 
 sonra kullanıcıdan bir string değer alın. Bu string değer dizinin içerisinde mevcutsa burada var,  değilse burada yok.... şeklinde bir mesajı ekrana yazdırın. 
 
 
 */


namespace a070DiziArama
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Dizi = { "Jale", "Semiha", "Mehmet", "Kamil", "Lale", "Cabbar", "Murtaza" };

            Console.WriteLine("Kimi aramıştınız?");

            string Aranan = Console.ReadLine();

            bool VarMi = false;


            for (int i = 0; i < Dizi.Length; i++)
            {
               
                if (Dizi[i] == Aranan)
                {
                    VarMi = true;
                    break;
                }
               // Dizi[i] = Dizi[i] + "*"; For döngüsünde dizi değerlerini değiştirmemizde bir sakınca yoktur.
            }

            foreach (string item in Dizi)
            {
                //item = item + "*"; Bu olmaz item readonly dir.
                if (item == Aranan)
                {
                    VarMi = true;
                    break;
                }

                
            }


            if (VarMi)
            {
                Console.WriteLine("Bekleyin çağıralım...");
            }
            else
            {
                Console.WriteLine("Öyle biri yok....");
            }

            Console.ReadLine();

        }
    }
}
