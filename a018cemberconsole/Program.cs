using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a018CemberConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen çemberin yarıçapını giriniz: ");
            int r = int.Parse(Console.ReadLine());

            double Cevre = 2 * Math.PI * r;
            double Alan = Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Girmiş olduğunuz çemberin çevresi : " + Cevre);
            Console.WriteLine("Girmiş olduğunuz çemberin alanı : " + Alan);

            Console.ReadLine();
             


        }
    }
}
