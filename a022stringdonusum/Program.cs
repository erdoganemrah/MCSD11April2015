using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace a022StringDonusum
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringSayi = "12A";
            int S = int.Parse(StringSayi);
           
            Console.WriteLine(S + 5);
            Console.WriteLine(StringSayi + 5);
            Console.ReadLine();
            //double.Parse();
            //long.Parse();
            //byte.Parse();

            string DigerString = Console.ReadLine().ToString();
            SqlConnectionStringBuilder SBC = new SqlConnectionStringBuilder();
          
        }
    }
}
