using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Dizi sıralama

namespace a074DiziSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] D = { 4, 2, 5, 3, 1, 8, 6, 4, 1, 3, 9 };

            bool Degisim = true;
            for (; Degisim == true; )
            {
                Degisim = false;
                for (int i = 0; i < D.Length - 1; i++)
                {
                    if (D[i] > D[i + 1])
                    {
                        int Temp = D[i];
                        D[i] = D[i + 1];
                        D[i + 1] = Temp;
                        Degisim = true;
                    }
                }
            }

            Console.ReadLine();



        }
    }
}
