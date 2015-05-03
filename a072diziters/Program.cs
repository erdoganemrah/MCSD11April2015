using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bir diziyi tersine çevirelim....
namespace a072DiziTers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Dizi = { 3, 4, 5, 1, 2 };

            int n = Dizi.Length;

            int[] Ters = new int[n];

            for (int i = 0; i < n; i++)
            {
                int YeniIndis = n - i - 1;
                Ters[YeniIndis] = Dizi[i];
            }



            foreach (int item in Ters)
            {
                Console.WriteLine(item);
                Console.WriteLine(", ");
            }

    
        
            Console.ReadLine();



        }
    }
}
