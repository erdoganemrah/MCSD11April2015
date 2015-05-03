using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a107MethodOverloading
{
    class Program
    {
        // Method Aşırı Yükleme, Method Overloading
        // Overloading method hazırlamak için ya farklı sayıda ya da tipte parametreler alan ayrı ayrı methodlar yazmamız gerekir.

        static int UsAl(int x)
        {
            return x * x;
        }

        /// <summary>
        /// İki farklı sayının çarpımını int olarak verir.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int UsAl(int x, int y)
        {
            return x * y;
        }

        static void Main()
        {
            var u = UsAl(6,12);
            var k = UsAl(11);
            Console.WriteLine(u);
            Console.ReadLine();
        }
    }
}
