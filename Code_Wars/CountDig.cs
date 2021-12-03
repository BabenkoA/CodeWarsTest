using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public class CountDig
    {
        public static int NbDig(int n, int d)
        {
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                count += Math.Pow(i, 2).ToString().Count(x => x.Equals((char)(d + 48)));
            }

            return count;
        }
    }
}
