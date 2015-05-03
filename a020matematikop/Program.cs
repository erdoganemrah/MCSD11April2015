using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a020MatematikOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Lütfe X sayısını giriniz:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfe Y sayısını giriniz:");
            y = int.Parse(Console.ReadLine());


            x = x + y;
            x += y;
            Console.WriteLine("x : " + x);

           
            Console.ReadLine();
        }
    }
}
