using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragmatechTask02
{
    class Program
    {
        static void Main(string[] args)
        {

            User user = new User();

            Console.WriteLine("Please enter your Fullname:");
            user.FullName = Console.ReadLine();
            Console.WriteLine("Please enter your email:");
            user.Email = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            user.Password = Console.ReadLine();
            user.PasswordChecker(user.Password);

            Console.WriteLine("Please choose an operation");
            Console.WriteLine("1-Show my information");
            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    user.ShowInfo();
                    break;
            }
            Console.ReadLine();
        }
    }
}
