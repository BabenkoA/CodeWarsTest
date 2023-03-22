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

            //Console.WriteLine(Kata.Longest("aretheyhere", "yestheyarehere"));
            int value = 10;
            int a = Enumerable.Range(0, value).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            //   Console.WriteLine(a);
            int[] seq = new int[] {2,2,2,5,5};
            int n = seq.GroupBy(x => x).Where(x => x.Count() % 2 != 0).Select(x=>x.Distinct().FirstOrDefault()).Single();
            /* foreach (int item in n)
             {
                 Console.WriteLine(item);
             }*/
            Console.WriteLine(Kata.findNb(1071225));

            string data = "iiisdoso";
            List<int> outp = new List<int>();
            int num = 0;
            foreach (char item in data)
            {
                switch (item)
                {
                    case 'i':
                        num++;
                        break;
                    case 'd':
                        num--;
                        break;
                    case 's':
                        num = (int)Math.Pow(num, 2);
                        break;
                    case 'o':
                        outp.Add(num);
                        break;
                    default:
                        break;
                }
            }
            outp.ToArray();
        }
    }
}
