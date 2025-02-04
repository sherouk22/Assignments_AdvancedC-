using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

       public static bool IsMatching(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '{' && closing == '}') ||
                   (opening == '[' && closing == ']');
        }


        public static bool IsBalanced(string input)
        {

            Stack<char> stack = new Stack<char>();


            foreach (char ch in input)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }

                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }


                    char top = stack.Pop();


                    if (!IsMatching(top, ch))
                    {
                        return false;
                    }
                }
            }


            return stack.Count == 0;
        }

        public static bool IsPalindrome(int[] array)
        {
            int left = 0; 
            int right = array.Length - 1; 

            
            while (left < right)
            {
                if (array[left] != array[right])
                {
                    return false; 
                }
                left++;
                right--;
            }

            return true; 
        }

        static void Main(string[] args)
        {


            #region 1. Given an array consists of numbers with size N and number of 

            //int size = int.Parse(Console.ReadLine());

            //int numQereies = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int[] Qereies = new int[numQereies];
            //for (int i = 0; i < size; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    arr[i] = X;
            //}
            //for (int i = 0; i < numQereies; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    Qereies[i] = X;
            //}

            //CountGreater(arr, Qereies);

            //void CountGreater(int[] arr, int[] Qereies)
            //{
            //    for (int i = 0; i < numQereies; i++)
            //    {
            //        int count = 0;
            //        foreach (int X in arr)
            //        {
            //            if (X > Qereies[i])
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine(count);
            //    }
            //}

            #endregion


            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.WriteLine("Enter the Size of Array..");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());

            //}

            //if (IsPalindrome(arr))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //static void ReverseQueue(Queue<int> queue)
            //{

            //    Stack<int> stack = new Stack<int>();


            //    while (queue.Count > 0)
            //    {
            //        stack.Push(queue.Dequeue());
            //    }


            //    while (stack.Count > 0)
            //    {
            //        queue.Enqueue(stack.Pop());
            //    }
            //}
            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue:");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //Console.WriteLine("Enter the string..");
            //string input = Console.ReadLine();

            //if (IsBalanced(input))

            //    Console.WriteLine("Balanced");
            //else

            //    Console.WriteLine("Not Balanced");

            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] array = { 1, 2, 3, 4, 2, 3, 5, 1, 7, 7 };


            //int[] uniqueArray = RemoveDuplicates(array);


            //Console.WriteLine("Array after removing duplicates:");
            //foreach (int num in uniqueArray)
            //{
            //    Console.WriteLine(num + " ");
            //}



            //static int[] RemoveDuplicates(int[] array)
            //{

            //    HashSet<int> uniqueSet = new HashSet<int>(array);


            //    int[] uniqueArray = uniqueSet.ToArray();

            //    return uniqueArray;
            //} 

            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList Numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };

            //Console.WriteLine("Original ArrayList:");
            //foreach (int i in Numbers)
            //    Console.WriteLine(i);

            //RemoveOddNumbers(Numbers);

            //Console.WriteLine("After removing odd numbers:");
            //foreach (int i in Numbers)
            //    Console.WriteLine(i); 

            #endregion

            #region 7. Implement a queue that can hold different data types.

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (object i in queue)
            //{
            //    Console.WriteLine(i);
            //} 

            #endregion




        }
    }
}
