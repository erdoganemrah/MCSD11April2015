using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a065WhileNested
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Satır sayısını giriniz");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütun sayısını girin");
            int x = int.Parse(Console.ReadLine());

            while (y>0)
            {
                int Sayac = x;
                while (Sayac > 0)
                {
                    Console.Write("X");
                    Sayac--;
                }


                Console.WriteLine();
                y--;
            }

            Console.ReadLine();

           
            
            



        }
    }
}
