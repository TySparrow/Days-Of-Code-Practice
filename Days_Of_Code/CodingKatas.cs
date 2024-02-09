using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Days_Of_Code
{
    public class CodingKatas
    {
        /* 
         * Exercise 1:
         Create an integer array method called SwapEnds that takes 
         in an integer array "nums". Given an array of ints, swap the first and last elements 
         in the array. Return the modified array. The array length will be at least 1.
         For example:
         swapEnds([1, 2, 3, 4]) → [4, 2, 3, 1]
         swapEnds([1, 2, 3]) → [3, 2, 1]
         swapEnds([8, 6, 7, 9, 5]) → [5, 6, 7, 9, 8]
        */

        public int[] SwapEnds(int[] nums)
        {
            int firstElement = nums[0];
            int lastElement = nums[nums.Length - 1];

            nums[0] = lastElement;
            nums[nums.Length - 1] = firstElement;

            return nums;
        }

        /*
         * Exercise 2:
        Create a boolean method called Has12 that takes in an integer array "nums". 
        Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in the array.
        For example:
        has12([1, 3, 2]) → true
        has12([3, 1, 2]) → true
        has12([3, 1, 4, 5, 2]) → true
        */
        public bool Has12(int[] nums)
        {
            bool hasOneThenTwo = false;
            if (nums.Length <= 1)
            {
                return hasOneThenTwo = false;
            }

            int oneIndex = Array.IndexOf(nums, 1);

            if (oneIndex >= 0 && nums.Length > 1)
            {
                for (int i = oneIndex; i < nums.Length; i++)
                {
                    if (nums[i] == 2)
                    {
                        hasOneThenTwo = true;
                        break;
                    }

                }
            }
            return hasOneThenTwo;
        }

        /*
         * Exercise 3:
         Create an integer method called GreenTicket that takes in three integers, "a". "b", and "c"
         You have a green lottery ticket, with ints a, b, and c on it. 
         If the numbers are all different from each other,  the result is 0. 
         If all of the numbers are the same, the result is 20. If two of the numbers are the same, the  result is 10.
         Example:
            greenTicket(1, 2, 3) → 0
            greenTicket(2, 2, 2) → 20
            greenTicket(1, 1, 2) → 10
        */
        public int GreenTicket(int a, int b, int c)
        {
            int ticketTotal = 0;

            if (a == b && a == c && b == c)
            {
                ticketTotal = 20;
            }
            else if ((a == b && a != c) || (a == c && a != b))
            {
                ticketTotal = 10;
            }
            else
            {
                ticketTotal = 0;
            }
            return ticketTotal;
        }
        /*
        Exercise 4:
        Create an integer method called Start1 that takes in two integer arrays "a" and "b". 
        Start with 2 int arrays, a and b, of any length. Return how many of the arrays have 1 as their first element.
        Example:
            start1([1, 2, 3], [1, 3]) → 2
            start1([7, 2, 3], [1]) → 1
            start1([1, 2], []) → 1
        */
        public int Start1(int[] a, int[] b)
        {
            int oneCounter = 0;

            if (a.Length == 0 && b.Length == 0)
            {
                return 0;
            }
            if (a[0] == 1)
            {
                oneCounter++;
            }
            if (b[0] == 1)
            {
                oneCounter++;
            }
            return oneCounter;
        }
        /*
         * Exercise 5:
          Create an integer array method called FizzArray3  that takes in two integers "start" and "end"
          Given start and end numbers, return a new array containing the sequence of integers from start up to but not including 
          end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The end number will be greater or equal  to the start number. 
          Note that a length-0 array is valid.
            Examples:
            fizzArray3(5, 10) → [5, 6, 7, 8, 9]
            fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
            fizzArray3(1, 3) → [1, 2]
        */
        public int[] FizzArray3(int start, int end)
        {
            if (end < start)
            {
                return new int[] { };
            }

            int[] startEndArray = new int[(end - start)];
            int startingCounter = start;


            for (int i = 0; i < startEndArray.Length; i++)
            {
                startEndArray[i] = startingCounter;
                startingCounter++;
            }
            return startEndArray;
        }
        /*
         * Exercise 6:
         Create a boolean method called Only14 that takes in an integer array “nums.” 
         Given an array of ints, return true if every element is a 1 or a 4.
            Examples:
            only14([1, 4, 1, 4]) → true
            only14([1, 4, 2, 4]) → false
            only14([1, 1]) → true
        */
        public bool Only14(int[] nums)
        {
            bool hasOneOrFour = true;

            if (nums.Length == 0)
            {
                return hasOneOrFour = false;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 1 && nums[i] != 4)
                {
                    hasOneOrFour = false;
                    break;

                }
            }
            return hasOneOrFour;
        }
        /*
         * Exercise 7:
         Create a boolean method called NoTuples that takes in an integer array “nums”.  
         Given an array of ints, we'll say that a triple is a value appearing 3 times in a row in the array. 
         Return true if the array does not contain any triples.
            Examples:
            noTriples([1, 1, 2, 2, 1]) → true
            noTriples([1, 1, 2, 2, 2, 1]) → false
            noTriples([1, 1, 1, 2, 2, 2, 1]) → false
        */
        public bool NoTuples(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return true;
            }

            bool noTriplets = true;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] == nums[i + 2])
                {
                    noTriplets = false;
                    break;
                }


            }
            return noTriplets;
        }
        /*
        Exercise 23:
        Create an integer method called ArrayCount9 that takes in an integer array “nums”. 
        Given an array of ints, return the number of 9's in the array.
            Examples:
            arrayCount9([1, 2, 9]) → 1
            arrayCount9([1, 9, 9]) → 2
            arrayCount9([1, 9, 9, 3, 9]) → 3
        */
        public int ArrayCount9(int[] nums)
        {
            int nineCounter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 9)
                {
                    nineCounter++;
                }
            }
            return nineCounter;
        }

        /*
         Exercise 29: Fibonacci  (new for V3)
        Create an integer array method called Fibonacci that takes in no arguments or parameters. 
        In a Fibonacci  sequence, every number after the first two is the sum of the two preceding ones. 
        Create a method that returns a Fibonacci sequence that begins 0,1,1,2,3,.... for the values less than 2000.
        fibonacci () → ([1,1,2,3,5,8,13,....,987,1597])
        */
        public int[] Fibonacci()
        {
            List<int> sequence = new List<int>();

            int first = 0;
            int second = 1;

            sequence.Add(first);
            sequence.Add(second);

            int next = first + second;

            while (next < 2000)
            {
                sequence.Add(next);
                first = second;
                second = next;
                next = first + second;
            }

            return sequence.ToArray();
        }
        /*
         Exercise 25: 
        Create a boolean method called IsStrictlyIncreasing that takes in an integer array “nums”. 
        Given an array of integers, return true if the values are strictly increasing. Return false otherwise.
            Examples:
            isStrictlyIncreasing([5,7,8,10]) → true
            isStrictlyIncreasing([5,7,7,10]) → false
            isStrictlyIncreasing([-5,-3,0,17]) → true
        */
        public bool IsStrictlyIncreasing(int[] nums)
        {
            bool isIncreasing = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }
            return isIncreasing;
        }
        /*
        Exercise 32:
        Create an integer method called Factorial that takes in an integer “n” and returns the factorial of the number. 
        If the integer is represented with the letter n, a factorial (n!) is the product of all positive integers less than or equal to n.
        factorial(3) → (6)
        factorial(4) → (24)
        factorial(10) → (3628800)
        */
        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }

            int bigNumber = 1;

            for (int i = 1; i <= n; i++)
            {
                bigNumber *= i;
            }
            return bigNumber;
        }
        /*
        Exercise 36: 
        Create a string method called FrontTimes that takes in a string “str” and an integer “n”. 
        Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, 
        or whatever is there if the string is less than length 3. Return n copies of the front;
         Examples:
         frontTimes("Chocolate", 2) → "ChoCho"
         frontTimes("Chocolate", 3) → "ChoChoCho"
         frontTimes("Abc", 3) → "AbcAbcAbc"
        */
        public string FrontTimes(string str, int n)
        {
            //n Cannot be negative, but need to check if it is 0 first, and return empty string
            if (n == 0)
            {
                return "";
            }

            //New string to be returned
            string copiedString = "";

            if (str.Length <= 3)
            {
                //Check string length if it is <= 3, return str n times
                //If string > 3, return substring of 3 n times
                for (int i = 0; i < n; i++)
                {
                    copiedString += str;
                }
                return copiedString;
            }
            //Loop through strings > 3, concat substrings together

            for (int i = 0; i < n; i++)
            {
                copiedString += str.Substring(0, 3);
            }
            return copiedString;
        }


        /*
         * The median of a list of numbers is essentially its middle element after sorting. The same number of elements
         * occur after it as before. Given a list of numbers with an odd number of elements, find the median?
         * Complete the findMedian function in the editor below.
         * findMedian has the following parameter(s): int arr[n]: an unsorted array of integers
         * 
         * Returns:
         * int: the median of the array
         * 
         * Input Format:
         * The first line contains the integer n, the size of arr.
         * The second line contains n space-separated integers arr[i]
         * 
         * Constraints:
         * 1 < n < 1000001
         * n is odd
         *-10000 <= arr[i] <= 10000
         */

        public int FindMedian(List<int> arr)
        {
            if (arr.Count == 1)
            {
                return arr[0];
            }
            arr.Sort();

            int middleIndex = arr.Count / 2;
            int median = arr[middleIndex];
            return median;
        }

        //Write a method that takes a string of parentheses, and determines if the order of the parentheses is valid.
        //The method should return true if the string is valid, and false if it's invalid.
        //Method name is ValidParentheses
        //    Examples
        //    "()"              =>  true
        //    ")(()))"          =>  false
        //    "("               =>  false
        //    "(())((()())())"  =>  true
        //    Constraints
        //    0 <= input.length <= 100
        //    Along with opening(() and closing ()) parenthesis, input may contain any valid ASCII characters.
        //    Furthermore, the input string may be empty and/or not contain any parentheses at all.
        //    Do not treat other forms of brackets as parentheses(e.g. [], { }, <>).
        public bool ValidParentheses(string str)
        {
            //Check edge cases -- Empty string, null, or starting with closing paren = false
            //String can also contain no '(' or ')'. For this I am treating it as false.

            if (str.Length == 0 || str == null || (str.Substring(0, 1) == ")"))
            {
                return false;
            }
            else if (!str.Contains("(") && !str.Contains(")"))
            {
                return false;
            }

            //Need counter that will increase with '(' and decrease with ')'
            int parenCounter = 0;

            //Loop through string
            //If char = '(' increase the counter by 1.
            //If char = ')' decrease the counter by 1.
            foreach (char c in str)
            {
                if (c == '(')
                {
                    parenCounter++;
                }
                else if (c == ')')
                {
                    parenCounter--;
                }
            }
            //If parentheses are balanced, return true, else return false
            if (parenCounter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }


        //Write a method called returnMost/ReturnMost that takes in a string and returns the character that appears
        //the most in the string

        //EX returnMost("Hi, this is my string") => returns i
        //String parameter may be length 0 or null

        public char ReturnMost(string str)
        {
            //Check if string is length 0 or null, return space char
            if(str.Length == 0 || str == null)
            {
                return ' ';
            }
            //Create a new instance of a dictionary to have <char, int> to count all characters in string
            Dictionary<char, int> map = new Dictionary<char, int>();

            //Loop through string
            foreach(char c in str)
            {
                if(c != ' ')
                {
                    //Make sure char is case insensitive -- make them all lower case
                    char lowerCaseChar = Char.ToLower(c);
                    //Add new KVP's if char is not already in dictionary
                    if(!map.ContainsKey(lowerCaseChar))
                    {
                        map[lowerCaseChar] = 1;
                    }
                    else
                    {
                        //Else, Update int counter for key if char is already in dictionary
                        map[lowerCaseChar]++;
                    }
                }
            }
            //Set up an int variable to assign value for most occurring char
            int charCount = 0;
            //Set up char variable to assign and return at the end
            char mostChar = '\0';

            //Loop through dictionary after string is done
            foreach(KeyValuePair<char, int> kvp in map)
            {
                //Find highest count for pair
                if (kvp.Value > charCount)
                {
                    charCount = kvp.Value;
                    mostChar = kvp.Key;
                }
            }
            //Return char with highest int
            return mostChar;
        }
    }
}
