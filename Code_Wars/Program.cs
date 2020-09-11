using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    class Program
    {
        private static readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

        static void Main(string[] args)
        {
            PagnationHelper<int> helper = new PagnationHelper<int>(collection, 10);
            //Console.WriteLine(Kata.RomanConvert(1990));
            //Console.WriteLine(Kata.is_prime(5099));
            //Console.WriteLine(Kata.MakeComplement("ATCG"));
            //Console.WriteLine(Kata.IQtest("2 4 7 8 10"));
            //Console.WriteLine(Kata.IQtest("1 3 5 8 9"));
            //Console.WriteLine(Kata.IQtest("1 3 3 3"));
            // Console.WriteLine(Kata.IQtest("15 13"));

            //Console.WriteLine(helper.PageItemCount(3));
            Console.WriteLine(helper.PageIndex(24));
        }
    }
}
