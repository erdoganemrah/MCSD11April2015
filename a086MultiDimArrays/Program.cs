using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a086MultiDimArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çok boyutlu diziler
            string[,] dizi = new string[10, 2];

            dizi[0, 0] = "Ahmet";
            dizi[0, 1] = "Soylu";

            dizi[1, 0] = "Mehmet";
            dizi[1, 1] = "Seyfioğlu";

            // Dağınık dizi
            string[][] yerlesimler = new string[81][];
            yerlesimler[0] = new string[8];
            yerlesimler[1] = new string[5];
            yerlesimler[2] = new string[16];
            yerlesimler[33] = new string[41];

            yerlesimler[0][0] = "Ceyhan";
            yerlesimler[0][0] = "Çukurova";
        }
    }
}
