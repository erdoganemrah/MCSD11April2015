using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a006Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörler
            //Matematiksel Operatörler
            int a = 15;
            int b = 25;

            int T = a + b;//*,/,-,%
            T = a * b - b + a % 5;
            T = a % 2;
            T = (((a * b) - b) + a % 5) * 9;

            a = 15;
            a++;
            ++a;

            b--;
            --b;

            T = a++;

            Console.WriteLine(T);//18,15,16,17
            Console.WriteLine(a);

            Console.Clear();
            T = ++a;

            Console.WriteLine(T);//18,15,16,17
            Console.WriteLine(a);

            //İşlemli Atama Operatörleri

            a = a + 5;

            a += 5;

            a = a * 5;
            a *= 5;
            a -= 5;
            a /= 3;

            a = 3;

            T = a / 3;

           

            Console.Clear();
            Console.WriteLine("Merhaba");
            Console.WriteLine(10 / 3.0);


            Console.Clear();
            T = 3 + 5;



            Console.WriteLine(T);
            Console.WriteLine("3" + "5");



           
            Console.ReadLine();


        }
    }
}
