using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    internal class UserValidator
    {
        public bool CheckPassword(string pas)
        {
            if (!string.IsNullOrWhiteSpace(pas) && pas.Length > 1 && pas.Length < 9)
                return true;
            return false;
        }

        public bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length > 2 && name.Length < 11)
                return true;
            return false;
        }
    }
}
