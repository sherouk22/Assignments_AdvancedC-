using System.Collections;

namespace Assignments_AdvancedC_
{
    internal class Program
    { //Assignment02_AdvancedC#02

        public static void RemoveOddNumbers(ArrayList Numbers)
        {
            for (int i = Numbers.Count - 1; i >= 0; i--)
            {
                if ((int)Numbers[i] % 2 != 0) 
                {
                    Numbers.RemoveAt(i); 
                }
            }

        }



        static void Main(string[] args)
        {





            #region 6. Given an array list , implement a function to remove all odd numbers from it.

                        ArrayList Numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine("Original ArrayList:");
            foreach (int i in Numbers)
                Console.WriteLine(i);

            RemoveOddNumbers(Numbers);

            Console.WriteLine("After removing odd numbers:");
            foreach (int i in Numbers)
                Console.WriteLine(i); 
            #endregion

        }
    }
}
