using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_AdvancedC_
{
    public class Helper<T> where T : IComparable
    {


        public static void Swap(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
        public static void BubbleSort(T[] Arr)
        {
            if (Arr == null || Arr.Length == 0)
                return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for(int j = 0; j < Arr.Length -1 -i; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1])==1)

                        Swap(ref Arr[j], ref Arr[j + 1]);

                }
            }

        }
    }
}
