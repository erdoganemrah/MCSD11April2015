using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a008MantiksalOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool p = false;
            bool q  = true;


            bool Sonuc = p && q;
            //Eğer p ve q ikisi birden doğru ise doğru, 
            //diğer durumlarda yanlış sonucunu üretiyor.


            Sonuc = p || q;
            //Eğer herhangi biri doğru ise doğru 
            //diğer durumlarda yanlış sonucu döndürür

            int a = 18;
            int b = 25;

            Sonuc = a == b && a < 9;

            bool d = true;

            bool e = !d;
            //e nin değeri eğer d true ise false, değilse true olur.

            e = !(a < b);
            
        }
    }
}
