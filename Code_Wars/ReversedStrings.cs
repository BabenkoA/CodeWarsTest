using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class ReversedStrings
    {
        public static string Solution(string str)
        {
            return new string(str.ToCharArray().Reverse().ToArray());
        }
    }
}
