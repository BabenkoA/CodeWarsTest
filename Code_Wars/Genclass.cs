using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars
{
    class Genclass<T>
    {
        private T[] arr;
        public int Length { get { return arr.Length; } }

        public Genclass()
        {
            arr = new T[0];
        }

        public void Add(T item) 
        {
            Array.Resize<T>(ref arr, Length + 1);
            arr[Length - 1] = item;
        }

        public void Remove() 
        {
            Array.Resize<T>(ref arr, Length - 1);
        }

        public T Find(int index) 
        {
            try
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.ToString()); 
                return default(T);
            }
            return arr[index];

        }

        public int FindFirstIndex(T item) => arr.ToList<T>().IndexOf(item);

        public void Show()
        {
            foreach (T item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Account
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public Account(int id)
        {
            Id = this.Id;
        }
    }

    class Transaction<T> where T: Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }

        public void Execute() 
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"{FromAccount.Id} : {FromAccount.Sum}\n {ToAccount.Id} : {ToAccount.Sum}");
            }
        }

    }
}
