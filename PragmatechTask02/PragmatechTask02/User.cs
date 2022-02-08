using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragmatechTask02
{
    public class User : Account
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public override void PasswordChecker(string Pass)
        {
            bool result;
            string CheckPasword = Pass;
            if (CheckPasword.Length >= 8 & CheckPasword != CheckPasword.ToLower() & CheckPasword != CheckPasword.ToUpper())
            {
                result = true;
                Console.WriteLine($"Password status: {result}");
            }
            else
            {
                result = false;
                Console.WriteLine($"Password status: {result}");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Your FullName: {FullName}/Your Email: {Email}");
        }
    }
}
