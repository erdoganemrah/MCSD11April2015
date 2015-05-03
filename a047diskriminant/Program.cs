using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a047Diskriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax^2 + bx + c = 0 denklemindeki a,b,c değerlerini giriniz....");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double Delta = b * b - 4 * a * c;

            string Mesaj = "";

            double Kok1 = 0, Kok2 = 0;


            if (Delta < 0)
            {
                Mesaj = "Denklemin gerçek bir kökü yoktur...";
            }
            else if (Delta == 0)
            {
                Kok1 = -1 * b / 2 * a;
                Kok2 = Kok1;
                Mesaj = String.Format("Denklemin tek bir kökü var. O da : {0}", Kok1);
            }
            else
            {
                Kok1 = (-1 * b + Math.Sqrt(Delta)) / 2 * a;
                Kok2 = (-1 * b - Math.Sqrt(Delta)) / 2 * a;
                Mesaj = String.Format("Denklemin iki tane kökü var. Onlar da : {0} , {1}", Kok1, Kok2);
            }

            Console.WriteLine(Mesaj);

            Console.ReadLine();



           

        }
    }
}
