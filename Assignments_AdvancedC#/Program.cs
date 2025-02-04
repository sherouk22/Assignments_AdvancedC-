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



        static void Main(string[] args)
        {

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            Console.WriteLine("Enter the string..");
            string input = Console.ReadLine();

            if (IsBalanced(input))

                Console.WriteLine("Balanced");
            else

                Console.WriteLine("Not Balanced");

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

        }
    }
}
