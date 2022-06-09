using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    class Program
    {
        //private static readonly IList<int> collection = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

        static void Main(string[] args)
        {
            // PagnationHelper<int> helper = new PagnationHelper<int>(collection, 10);
            //Console.WriteLine(Kata.RomanConvert(1990));
            //Console.WriteLine(Kata.is_prime(5099));
            //Console.WriteLine(Kata.MakeComplement("ATCG"));
            //Console.WriteLine(Kata.IQtest("2 4 7 8 10"));
            //Console.WriteLine(Kata.IQtest("1 3 5 8 9"));
            //Console.WriteLine(Kata.IQtest("1 3 3 3"));
            // Console.WriteLine(Kata.IQtest("15 13"));

            //Console.WriteLine(helper.PageItemCount(3));
            //Console.WriteLine(helper.PageIndex(24));
            // Kata.Anagrams("aabbc", new List<string>());

            // Kata.Anagrams("racer", new List<string> { "carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr" });

            /*foreach (string s in Kata.Top3("a a b b b c'")) 
            {
                Console.WriteLine(s);
            }*/

            //Console.WriteLine( Kata.IsPangram("The quick brown fox jumps over the lazy dog."));

            //Kata.BreakCamelCase("camelCasingTest");

            // Console.WriteLine(Kata.EgyptianFraction("4", "8") );

            // Genclass<int> numbers = new Genclass<int>();
            // numbers.Add(1);

            //DelegateTrn delegateTrn = new DelegateTrn();

            //delegateTrn.mes();

            //DelegateMethods delegateMethod = new DelegateMethods(2,3);

            // Console.WriteLine(CountDig.NbDig(5750, 0)); 
            //Console.WriteLine(ReversedStrings.Solution("world"));
            //Console.WriteLine(Kata.AlphabetPosition("The ck."));
            //string text = "The ck.";
            //Console.WriteLine(text[1] - 96) ;

            //int n = 9119;
            //Console.WriteLine(int.Parse(string.Join("", n.ToString().Select(x => (int)Math.Pow(int.Parse(x.ToString()), 2)))));

            string p = "man i need a taxi up to ubud";
            string[] words = p.Split(' ');
            string max = words[0];
            int count;
            int max_count = 0;
            foreach (string str in words)
            {
                count = 0;
                foreach (char c in str)
                {
                    count += c-96;
                }
                if (max_count < count) 
                {
                    max_count = count;
                    max = str;
                }
            }

            Console.WriteLine(max);
        }
    }
}
