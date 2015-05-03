using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a047IfUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dijital oyun sever misiniz?");
            string Cevap = Console.ReadLine();

            if (Cevap == "Evet")
            {
                Console.WriteLine("Git kendine bir bilgisayar al...");
            }
            else
            {
                Console.WriteLine("Hiç arkadaşın var mı?");
                Cevap = Console.ReadLine();

                if (Cevap == "Hayır")
                {
                    Console.WriteLine("PS3 Al.");
                }
                else
                {
                    Console.WriteLine("[G]erçen arkadaşlar mı yoksa [S]anal arkadaşlar mı?");
                    Cevap = Console.ReadLine();
                    if (Cevap == "G")
                    {
                        Console.WriteLine("Wii al");
                    }
                    else
                    {
                        Console.WriteLine("Xbox 360 al!");
                    }
                }

                Console.ReadLine();

            }
        }
    }
}

