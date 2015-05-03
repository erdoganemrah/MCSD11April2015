using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a027Kosul
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen yaşınızı giriniz : ");
            int Yas = int.Parse(Console.ReadLine());

            Yas += 0;

            if (Yas>16)
            {
                Console.WriteLine("Macera oyunları oynayabilirsiniz");
            }

            Console.WriteLine("Hoş geldiniz.");

            Console.ReadLine();


        }
    }
}
