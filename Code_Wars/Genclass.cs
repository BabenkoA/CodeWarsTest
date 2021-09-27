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
    }
}
