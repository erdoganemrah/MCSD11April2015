using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a004Type
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tamsayı Tipler
            byte b = 0;
            Console.WriteLine("byte min : " + byte.MinValue);
            Console.WriteLine("byte max : " + byte.MaxValue);

            sbyte sb = 0;
            Console.WriteLine("sbyte min : " + sbyte.MinValue);
            Console.WriteLine("sbyte max : " + sbyte.MaxValue);

            short s = 0;
            Console.WriteLine("short min : " + short.MinValue);
            Console.WriteLine("short max : " + short.MaxValue);

            ushort us = 0;
            Console.WriteLine("ushort min : " + ushort.MinValue);
            Console.WriteLine("ushort max : " + ushort.MaxValue);


            int i = 0;
            Console.WriteLine("int min : " + int.MinValue);
            Console.WriteLine("int max : " + int.MaxValue);


            uint ui = 0;
            Console.WriteLine("uint min : " + uint.MinValue);
            Console.WriteLine("uint max : " + uint.MaxValue);

            long l = 0;//8 byte
            Console.WriteLine("long min : " + long.MinValue);
            Console.WriteLine("long max : " +String.Format("{0:N}",long.MaxValue));

            ulong ul = 0;//8 byte
            Console.WriteLine("ulong min : " + ulong.MinValue);
            Console.WriteLine("ulong max : " + String.Format("{0:N}", ulong.MaxValue));



            //Ondalık Tipler
            float F = 1.5F;
            //Ondalık  ayracı olarak daima . kullanırız.
            //Float tipine atama yaparken sabit değerin sonuna F harfi koyarız.
            //Float tipi 32 bittir. Ondalık sayılar tutar.
            //Virgülden sonra 7 basamağa kadar önemsenir.

            Console.WriteLine("float min : " + float.MinValue);
            Console.WriteLine("float max : " + float.MaxValue);



            double D = 2.5D;
            //Double tipinde de sonuna D harfi koyabiliriz. Koymaya dabiliriz.
            //Sabit olarak yazdığımız ondalık değerler double olarak kabul edilir.
            //64 bit yer tutar
            //Virgülden sonraki 15 basamak değerlendirilir.
            Console.WriteLine("double min : " + double.MinValue);
            Console.WriteLine("double max : " + double.MaxValue);

            decimal DM = 4.5M;
            //Kesin ondalık tiptir. 128 bit yer yaplar.
            //Virgülden sonraki 28 basamağa kadar yuvarlama yapılmaksızın
            //kesin sonuçlarla çalışır.

            Console.WriteLine("decimal min : " + decimal.MinValue);
            Console.WriteLine("decimal max : " + decimal.MaxValue);


            //Karakter Tipleri
            char C = 'a';
            char C2 = 'B';
            char C3 = '5';
            char C4 = '/';
            //2 byte alanda tek bir karakter değeri taşır.
            //Değer ataması yaparken tek tırnak ' ile işaretleriz.

            string S1 = "Merhaba Dünya";
            string S2 = "5";
            string S3 = "";
            string S4 = String.Empty;
            string S5;
            //String tipi 2GB kadar metinsel değerleri tutabilmemizi sağlayan
            //bir tiptir. Atayacağımız değerleri " çift tırnak ile işaretleriz.

            string S7 = "Merhaba aşağıdaki satır. \n Merhaba yukarıdaki satır.";
            string S8 = "Bir pragraf boşluk. \t boşluktan sonrası.";

            Console.Clear();
            Console.WriteLine(S7);
            Console.WriteLine(S8);

            string Soz = "Oscar Wild : \"Dostun üzüntüsüne acı duyabilirsin. Bu kolaydır; ama dostun başarısına sempati duyabilmek, sağlam bir karakter gerektirir\". ";

            Console.WriteLine(Soz);
           

            string Path = "C:\\Users\\ders\\Dropbox\\BTA.MCPD.11Nisan2015\\Kardelen";
            Console.WriteLine();
            Console.WriteLine(Path);

            string Path2 = @"C:\Program Files (x86)\Android\android-studio\lib\ant\lib";
            //String ifadenin başına koyduğum @ işareti kaçış karakteri kullanmayacağımız manasına gelir.

            Console.WriteLine(Path2);

            string OzluSoz = @"Ömer Hayyam : ""Adalet evrenin ruhudur""";
            Console.WriteLine(OzluSoz);

            //Boolean Tipi

            bool B1 = true;
            bool B2 = false;

            //Object

            object o1 = "Merhaba";
            object o2 = 5;
            object o3 = true;
            object o4 = 'a';
            object o5 = 5.6;

            Console.ReadLine();
        }
    }
}
