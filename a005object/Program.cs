using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a005Object
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = a;
            a = 5;
            Console.WriteLine(b);//5,6,hata
           

            object m = 25;
            object k = m;
            m = 80;
            Console.WriteLine(k); 
            Console.ReadLine();
        }
    }
}
