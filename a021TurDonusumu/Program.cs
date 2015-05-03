using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a021TurDonusumu
{
    class Program
    {
        static void Main(string[] args)
        {

            //Bilinçsiz tür dönüşümü
            byte b = 9;

            int i = b;

            //Bilinçli tür dönüşümü

            int k = 14;
            byte m = 0;
            m = (byte)k;



            double d = 1.567;
            k = (int)d;

            Console.WriteLine(k);

            Console.ReadLine();

            checked
            {


                unchecked
                {
                    k = 1879;
                    m = (byte)k;

                    checked
                    {

                    }
                }

            }

            Console.WriteLine(m);//255,hata,0, X,

            Console.ReadLine();


        }
    }
}
