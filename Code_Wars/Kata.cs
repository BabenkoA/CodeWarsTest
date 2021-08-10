using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class Kata
    {
        // old work
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0:
                    return "no one likes this";
                case 1:
                    return name[0] + " likes this";
                case 2:
                    return name[0] + " and " + name[1] + " like this";
                case 3:
                    return name[0] + ", " + name[1] + " and " + name[2] + " like this";
                case int n when (n > 3):
                    return name[0] + ", " + name[1] + " and " + (n - 2) + " others like this";
                default:
                    return "no one likes this";
            }
        }

        public static int DontGiveMeFive(int start, int end)
        {
            int res = 0;
            for (int i = start; i <= end; i++)
            {
                if (i.ToString().IndexOf("5") != -1)
                {
                    continue;
                }
                res++;
            }
            return res;
        }

        public static string PigIt(string str)
        {
            Regex regex = new Regex(@"^(\w+)");
            Regex regex2 = new Regex(@"(\s)(\w+)");
            MatchCollection matches_f = regex.Matches(str);
            MatchCollection matches = regex2.Matches(str);

            foreach (Match match1 in matches_f)
            {
                str = str.Replace(match1.Value, match1.Value.Insert(match1.Value.Length, match1.Value.Substring(0, 1)).Remove(0, 1) + "ay");
            }

            foreach (Match match in matches)
            {
                str = str.Replace(match.Value, match.Value.Insert(match.Value.Length, match.Value.Substring(1, 1)).Remove(1, 1) + "ay");
            }
            Console.WriteLine(str);
            return str;
        }

        public static int RomanDecode(string roman)
        {
            Dictionary<char, int> rom_int = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int output = 0;

            for (int i = 0; i < roman.Length - 1; i++)
            {
                if (rom_int[roman[i]] < rom_int[roman[i + 1]])
                {
                    output -= rom_int[roman[i]];
                }
                else
                {
                    output += rom_int[roman[i]];
                }
            }
            output += rom_int[roman[roman.Length - 1]]; ;

            return output;
        }

        public static int MaxSubarray(int[] arr)
        {
            int max = 0;
            int prev, curr;
            if (arr.Length > 0)
                max = arr[0];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                prev = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    curr = prev + arr[j];
                    if (max < curr)
                    {
                        max = curr;
                    }
                    prev = curr;
                }
                if (arr[arr.Length - 1] > max)
                {
                    max = arr[arr.Length - 1];
                }
            }
            return max;
        }

        public static int[] Parse(string data)
        {
            List<int> list = new List<int>();
            int num = 0;
            foreach (char ch in data)
            {
                switch (ch)
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
                        list.Add(num);
                        break;
                    default: break;
                }
            }
            return list.ToArray();
        }

        public static string GetReadable(int seconds)
        {
            string hz = "", mz = "", sz = "";

            int mm_all = seconds / 60;
            int hh = mm_all / 60;
            if (hh < 10) { hz = "0"; };
            int mm = mm_all - hh * 60;
            if (mm < 10) { mz = "0"; }
            int ss = seconds % 60;
            if (ss < 10) { sz = "0"; }

            return hz + hh + ":" + mz + mm + ":" + sz + ss;
        }

        public static string GetReadableRefactoring(int seconds)
        {
            int mm_all = seconds / 60;
            int hh = mm_all / 60;
            int mm = mm_all - hh * 60;
            int ss = seconds % 60;
            string output = String.Format("{0:d2}:{1:d2}:{2:d2}", hh, mm, ss);
            return output;
        }

        public static int DigitRoot(long n)
        {
            int res = 0;
            if (n.ToString().Length <= 1)
            {
                return (int)n;
            }
            for (int i = 0; i < n.ToString().Length; i++)
            {
                res += Int32.Parse(n.ToString().Substring(i, 1));
            }
            return DigitRoot(res);
        }

        public static string ToUnderscore(string str)
        {
            string output = "";
            string[] words = Regex.Split(str, @"(?=[A-Z])");
            for (int i = 1; i < words.Length - 1; i++)
            {
                output += words[i].ToLower() + '_';
            }
            output += words[words.Length - 1].ToLower();
            return output;
        }
        //work

        public static string RomanConvert(int n) 
        {
                return  n >= 1000?  "M" + RomanConvert(n - 1000):
                        n >= 900 ? "CM" + RomanConvert(n - 900) :
                        n >= 500 ?  "D" + RomanConvert(n - 500) :
                        n >= 400 ? "CD" + RomanConvert(n - 400) :
                        n >= 100 ?  "C" + RomanConvert(n - 100) :
                        n >= 90  ? "XC" + RomanConvert(n - 90) :
                        n >= 50  ?  "L" + RomanConvert(n - 50)  :
                        n >= 40  ? "XL" + RomanConvert(n - 40) :
                        n >= 10  ?  "X" + RomanConvert(n - 10)  :
                        n >= 9   ? "IX" + RomanConvert(n - 9) :
                        n >= 5   ?  "V" + RomanConvert(n - 5)   :
                        n >= 4   ? "IV" + RomanConvert(n - 4) :
                        n >= 1   ?  "I" + RomanConvert(n - 1)   :"";
        }
        public static bool is_prime(int n) 
        {
            if (n <= 1) return false;
            if (n == 2) return true;

            double limit = Math.Ceiling(Math.Sqrt(n));

            for (int i = 2; i <= limit; i++) 
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static string MakeComplement(string dna) 
        {
             Dictionary<char, char> pairs = new Dictionary<char, char>
             {
                 {'A','T'},
                 {'G','C'},
                 {'T','A'},
                 {'C','G'}
             };
             string output="";
             for (int i = 0; i < dna.Length; i++) 
             {
                 output += dna.Substring(i,1).Replace(dna[i],pairs[dna[i]]);
             }
             return output;
        }

        public static int IQtest(string numbers)
        {
            int [] numbers_int = numbers.Split(' ').Select(n=>Convert.ToInt32(n)).ToArray();
            bool[] odd = new bool[numbers_int.Length];
            bool[] other = new bool[numbers_int.Length];
            int count_false = 0, count_true = 0;


            for(int i =0;i< numbers_int.Length;i++)
            {
                if (Int32.Parse(numbers_int[i].ToString()) % 2 == 0)
                {
                    odd[i] = false;
                    count_false++;
                }
                else 
                {
                    odd[i] = true;
                    count_true++;
                }
            }
            if (count_false == 1)
            {
                for (int i = 0; i < odd.Length; i++)
                {
                    if (!odd[i])
                    {
                        return ++i;
                    }
                }
            }
            else if (count_true == 1)
            {
                for (int i = 0; i < odd.Length; i++)
                {
                    if (odd[i])
                    {
                        return ++i;
                    }
                }
            }
            else 
            {       
                   IEnumerable<bool> same = numbers_int.Select(n => n.Equals(numbers_int[0]));
                int c_true = same.Count(ch=>ch.ToString().Contains("True"));
                int c_false = same.Count(ch => ch.ToString().Contains("False"));
                return c_true == 1 ? same.ToList().IndexOf(true)+1 : same.ToList().IndexOf(false)+1;
            }
            return 0;
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            Dictionary<char,int> dictionary = new Dictionary<char, int>();
            List<string> anagrams = new List<string>();
            Dictionary<char, int> check = new Dictionary<char, int>();

            foreach (char ch in word) 
            {
                int count = word.Where(x => x.Equals(ch)).Count();
                if (!dictionary.Keys.Contains(ch))
                {
                    dictionary.Add(ch, count);
                }
            }

            foreach (string lst_word in words) 
            {
                foreach (char ch in lst_word)
                {
                    int count = lst_word.Where(x => x.Equals(ch)).Count();
                    if (!check.Keys.Contains(ch))
                    {
                        check.Add(ch, count);
                    }
                }
                if (check.Count == dictionary.Count) 
                {
                    bool check_word = true;
                    foreach (KeyValuePair<char, int> valuePair in check) 
                    {
                        if (dictionary.Keys.Contains(valuePair.Key))
                        {
                            if (check[valuePair.Key] != dictionary[valuePair.Key])
                            {
                                check_word = false;
                            }
                        }
                        else {
                            check_word = false;
                         }
                    }
                    if (check_word)
                    {
                        anagrams.Add(lst_word);
                    }
                }
                check.Clear();
            }

            return anagrams;

            //bp
            //var pattern = word.OrderBy(p => p).ToArray();
            //return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
        }

        //10.01.21
        public static List<string> Top3(string s) 
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            s = s.ToLower();
            Regex regex = new Regex(@"\w+('\w*)*");
            MatchCollection matches = regex.Matches(s);
            if (matches.Count > 0 ) 
            {
                foreach (Match match in matches) 
                {
                    //Console.WriteLine(match.Value);
                    if (!dictionary.Keys.Contains(match.Value))
                    {
                        dictionary.Add(match.Value, 1);
                    }
                    else 
                    {
                        dictionary[match.Value]++;
                    }
                }
            }
            else 
            {
                Console.WriteLine("There are no Matches");
            }

            return dictionary.OrderByDescending(x => x.Value).Take(3).Select(enty => enty.Key).ToList();
        }

        public static bool IsPangram(string str) => 26 == str.ToLower().Where(x => x >= 97 && x <= 122).Distinct().Count();

        public static int[] DeleteNth(int[] arr , int x) 
        {
             List<int> lst = new List<int>(arr);

             for(int i = 0; i < lst.Count; i++)
             {
                 int count = lst.Where(t => t == lst[i]).Count();
                 while (count > x) 
                 {
                     lst.RemoveAt(lst.LastIndexOf(lst[i]));
                     count--;
                 }
             }

             return lst.ToArray();   

            /*Codewars Best Practices*/
            /*var result = new List<int>();
            foreach (var item in arr)
            {
                if (result.Count(i => i == item) < x)
                    result.Add(item);
            }
            return result.ToArray();*/
        }

        //11.02.21 don't works
        public static long PowerSumDigTerm(int n)
        {
            long num = 80;
           
            for (int i = 0; i < n; i++)
            {
                int pow = 1;
                bool eq = false;
                while (!eq)
                {
                    num++;
                    int sum = num.ToString().Select(x => Int32.Parse(x.ToString())).ToList().Sum();

                    while (Math.Pow(sum, pow) <= num)
                    {
                        if (Math.Pow(sum, pow) == num)
                        {
                            eq = true;
                        }
                            pow++;
                    };
                }
            }

            return num;
        }

        //12.02.21

        public static ulong[] productFib(ulong prod)
        {
            List<ulong> fibonachi = new List<ulong> { 0, 1 };
            ulong mulProd;

            do
            {
                ulong newLast = fibonachi.Skip(fibonachi.Count() - 2).Take(2).ToArray().Aggregate((x,y)=> x+y);
                mulProd = fibonachi.Last() * newLast;
                fibonachi.Add(newLast);
            } while (mulProd < prod);

            return new ulong[] { fibonachi[fibonachi.Count-2], fibonachi.Last(), Convert.ToUInt16(mulProd == prod) };
        }

    }

    public class PagnationHelper<T> 
    {
        private IList<T> collect;
        private int item;
        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            collect = collection;
            item = itemsPerPage;
        }

        public int ItemCount
        {
            get
            {
                return collect.Count;
            }
        }

        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((decimal)collect.Count / (decimal)item);
            }
        }

        public int PageItemCount(int pageIndex)
        {
            return pageIndex < 0 || pageIndex > this.PageCount - 1 ? -1 : pageIndex < this.PageCount - 1 ? this.item : this.ItemCount - ((this.PageCount - 1) * this.item);
        }

        public int PageIndex(int itemIndex)
        {
            if (itemIndex < 0 || itemIndex >= this.ItemCount) return -1;

            if (itemIndex < item)
            {
                return 0;
            }
            else
            {
                int itemsLeft = itemIndex;
                int pages = 0;
                do
                {
                    itemsLeft -= item;
                    pages++;
                } while (itemsLeft >= item);

                return pages;
            }
        }

        //10.08.21
        public static string EgyptianFraction(string nrStr, string drStr)
        {
            // your code
            return null;
        }
    }
}
    