using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helper
{
    public class IntegerProblems
    {
        /// <summary>
        /// converts positive/negative number to array of digits but the digits in array are reversed
        /// ex: if input is 468, output is {8,6,4}
        /// Time complexity : O(number of digits in the array)
        /// </summary>
        /// <param name="n">input number</param>
        /// <returns>list of digits</returns>
        public static List<int> IntegerToReversedDigitArray(int n)
        {
            List<int> arr = new List<int>();
            int res = Math.Abs(n);
            if (res == 0)
            {
                arr.Add(0);
            }

            while (res != 0)
            {
                arr.Add(res % 10);
                res /= 10;
            }
            if (n < 0)
            {
                arr[arr.Count - 1] *= -1;
            }
            return arr;
        }
        /// <summary>
        /// converts positive/negative integer to array of individual digits in order from 0 index
        /// ex: -975 -- [-9, 7,5]
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<int> IntegerToDigitArray(int n) //-865
        {
            List<int> arr = new List<int>();
            int length = (n < 0) ? n.ToString().Length - 1 : n.ToString().Length;   //3

            int res = Math.Abs(n);                                                  //865
            if (length > 1)
            {
                for (int i = length - 1; i > 0; i--)                                //i=2 , 1
                {
                    int mul = Convert.ToInt32(Math.Pow(10, i));
                    arr.Add(res / mul);                                             //865/100 = 8 , 65/10 = 6
                    res %= mul;                                                     //65, 5
                }


            }
            arr.Add(res);
            if (n < 0)
            {
                arr[0] *= -1;
            }
            return arr;
        }
        /// <summary>
        /// gets the range of numbers between two numbers(not inclusive of last)
        /// Time Complexity : O(endNum - startNum)
        /// </summary>
        /// <param name="startNum">start number</param>
        /// <param name="endNum">end number</param>
        /// <returns>list of numbers</returns>
        public static List<int> RangeOfNumbers(int startNum, int endNum)
        {
            List<int> result = new List<int>();
            for (int i = startNum; i < endNum; i++)
            {
                result.Add(i);
            }
            return result;
        }
        /// <summary>
        /// combines the array of digits into single positive/negative integer
        /// order of input array is the order in which digits appear in the number
        /// Time complexity : O(n) where n is array length
        /// </summary>
        /// <param name="arr">array of digits</param>
        /// <returns>combined integer</returns>
        public static int DigitArrayToInteger(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result *= 10;
                result += Math.Abs(arr[i]);
            }
            return arr[0] < 0 ? result * -1 : result;
        }
        /// <summary>
        /// reverses a number for positive/negative integers
        /// ex: -987 --> -789
        /// Time complexity : 2 * O(number of digits) 
        /// </summary>
        /// <param name="n">number to be reversed</param>
        /// <returns>reversed number</returns>
        public static int ReverseNumber(int n)      //-879 --> -978
        {
            List<int> arr = IntegerToReversedDigitArray(n);       // 9 7 -8
            if (n < 0)
            {
                arr[0] *= -1;
                arr[arr.Count - 1] *= -1;
            }
            return (DigitArrayToInteger(arr.ToArray()));

        }
        /// <summary>
        /// gives the number of digits in an integer
        /// Time complexity : O(1)
        /// </summary>
        /// <param name="n">input number</param>
        /// <returns>number of digits</returns>
        public static int NumberOfDigits(int n)
        {
            return (n < 0) ? n.ToString().Length - 1 : n.ToString().Length;   //3
        }


    }
}
