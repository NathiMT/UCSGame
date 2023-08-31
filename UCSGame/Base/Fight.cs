using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCSGame.Base
{
    internal class Fight
    {
        public Fight() { }

        public int GetDamage(string option) 
        {
            if (option == "1")
                return 10;
            else if (option == "2")
                return 20;
            else
                return 0;
        }

        public bool ChangeDefense(bool defense)
        {
            return !defense;
        }
    }
}
