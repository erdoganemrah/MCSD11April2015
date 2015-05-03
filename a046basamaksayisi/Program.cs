using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a046BasamakSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir tamsayı giriniz : ");
            int T = int.Parse(Console.ReadLine());

            string ST = T.ToString();
            int BasamakSayisi = ST.Length;

            Console.WriteLine("Basamak sayısı : {0}", BasamakSayisi);

            Console.ReadLine();


        }
    }
}
