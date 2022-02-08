using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragmatechTask02
{
    public abstract class Account
    {
        public abstract void PasswordChecker(string Pass);

        public virtual void ShowInfo()
        {
             
        }
    }
}
