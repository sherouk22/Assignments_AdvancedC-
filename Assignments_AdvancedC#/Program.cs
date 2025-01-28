namespace Assignments_AdvancedC_
{
    internal class Program
    {
       // Assignment01_AdvancedC#01
        static void Main(string[] args)
        {
            #region 1. The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,

            //int[] Number = [1, 5, 3, 7, 2, 4, 6];

            //Console.WriteLine("Original array:");

            //foreach (int number in Number)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine(" array after sorrting:");

            //Helper<int>.BubbleSort(Number);



            //foreach (int number in Number)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion


            #region 2. create a generic Range<T> class that represents a range of values from a minimum value to a maximum value.

            //Range<int> range = new Range<int>(10, 40);

            //Console.WriteLine($"Is 15 in range ? {range.IsInRange(15)}");
            //Console.WriteLine($"Is 45 in range ? {range.IsInRange(45)}");

            //Console.WriteLine($"Length ?{range.Length()}");

            //Range<double> RangeD = new Range<double>(10.5, 16.0);


            //Console.WriteLine($"Is 15 in range ? {RangeD.IsInRange(15)}");
            //Console.WriteLine($"Is 45 in range ? {RangeD.IsInRange(45)}");

            //Console.WriteLine($"Length ?{RangeD.Length()}");

            //Range<string> range2 = new Range<string>("mona ", "ahmed");

            //Console.WriteLine("Is 'ahmed' in range? " + range2.IsInRange("ahmed"));

            #endregion

            #region 3. You are given an ArrayList containing a sequence of elements.
            //int[] Numbers = [1, 5, 6, 4, 3, 2];
            //Console.WriteLine("Original ArrayList:");
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);

            //}

            //Console.WriteLine("Reverse ArrayList:");

            //Helper<int>.ReverseArray(Numbers);

            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region 4. You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

                        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Even Numbers: " + string.Join(' ', Helper<int>.EvenNumbers(numbers))); 
            #endregion

        }
    }
}
