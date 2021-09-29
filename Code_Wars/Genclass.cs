﻿using System;
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
}
