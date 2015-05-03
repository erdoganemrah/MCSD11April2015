using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a116EnumUygulama
{
    class Program
    {
        /*
         * Usertype isminde bir enum tip oluşturun. Bu tipe ait alınabilecek değerler Admin, Mod, User, Guest olabilsin.
         * 
         * Bu tipte bir değişken tanımlayarak istediğiniz bir değeri atamayı deneyin.
         */
        enum UserType
        {
            Admin = 1,
            Mod = 2,
            User = 3,
            Guest = 0
        }

        static void Main(string[] args)
        {
            UserType user = UserType.Admin;

            string userType = "";
            user = (UserType)Enum.Parse(typeof(UserType), userType);

            Console.WriteLine(user);
            Console.ReadLine();
        }
    }
}
