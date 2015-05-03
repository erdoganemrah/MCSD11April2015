using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a090Parametresiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Çağrıldığında şuanki saniyeyi döndüren fonksiyonu hazırlayın.
            Console.WriteLine("Şu anki saniye:{0}", SuAnkiSaniye());
            Console.ReadLine();
        }

        static int SuAnkiSaniye()
        {
            return DateTime.Now.Second;
        }
    }
}
