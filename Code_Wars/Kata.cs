using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    public static class Kata
    {
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
                return (int)Math.Ceiling((decimal)collect.Count/(decimal)item);
            }
        }

        public int PageItemCount(int pageIndex)
        {
            return pageIndex<0 || pageIndex>this.PageCount-1? -1 : pageIndex < this.PageCount - 1? this.item: this.ItemCount - ((this.PageCount - 1) * this.item);
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

    }
}
    