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

        public static void ReverseArray(T[] Arr)
        {
            int left = 0;
            int right = Arr.Length - 1;


            while (left < right)
            {
                Swap(ref Arr[left], ref Arr[right]);



                left++;
                right--;
            }
        }


        public static void BSort(T[] arr) 
        {
            if (arr == null || arr.Length == 0)
            {

                return;
            }
            for (int i = 0; i < arr.Length - 1; i++)

            {
                bool flag = false;
                for (int j = 0; j < arr.Length - i - 1; j++)

                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        flag = true;
                    }

                }
                if (!flag)
                    break;
            }

        }


        public static List<int> EvenNumbers(List<int> numbers)
        {

            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }


    }
}
