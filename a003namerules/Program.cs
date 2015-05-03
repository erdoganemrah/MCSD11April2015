using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace a003NameRules
{
    class Program
    {
        static void Main(string[] args)
        {

            //Değişken isimlendirme kuralları

            //Değişken isimleri rakamla başlayamazlar.
            // 1kisi, 2degisken, 0birim gibi kullanımlar geçersizdir.
            int Kisi1, Kisi2, d2egisken;// geçerli

            //Boşluk, özel işaretler (?.,+%,& gibi) kullanamayız. _ kullanabiliriz ama tercih etmeyiz.
            // Kullanici Adi, Giris+Sayisi.10b, 
            int KisiAdi, Giris_Sayisi;

            //Değişken isimlendirirken kural olmasa da ilk harfi herzaman büyük yazarız.
            //Kalan harfleri de küçük yazarız.
            // Bu .net platformunda bir defacto standardıdır.
            //int kelime, kUllanici, PAROLA
            int Kelime, Kullanici, Parola;

            //Değişken ismi birden fazla kelime içeriyorsa her bir kelimenin baş harfini büyük yazarız.
            //Bu na pascal casing denmektedir.
            int KelimeAraligi, KullaniciAdi, ParolaIsaret;
            //Eğer camel casing olsaydı
            int kelimeAraligi, kullaniciAdi, parolaIsaret;

            Console.WriteLine();
            Console.ReadLine();

            int FıstıkçıŞahabettin;//Geçerli
            int हिन्दी = 98;

            int b = 9;
            int k, l, m, c;
            int p = 6, y = 19;
        }
    }
}
