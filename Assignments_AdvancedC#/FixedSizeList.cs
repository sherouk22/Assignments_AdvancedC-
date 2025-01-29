using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_AdvancedC_
{
    public class FixedSizeList<T>
    {
        private T[] Arr;
        private int Count;

        public FixedSizeList(int capacity)
        {
            Arr = new T[capacity];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count >= Arr.Length)
            {
                throw new InvalidOperationException("Cannot add more elements. The list is full.");
            }

            Arr[Count] = item;
            Count++;
        }


        public T Get(int count)
        {
            if (count < 0 || count >= Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return Arr[count];
        }


        public int Count1 => Count;


        public int Capacity1 => Arr.Length;

    
    }
}
