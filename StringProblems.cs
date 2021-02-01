using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Helper
{
    public class StringProblems
    {

        /// <summary>
        /// reverses input string
        /// </summary>
        /// <param name="str">string - can be empty or one or more characters</param>
        /// <returns>reversed string</returns>
        public static string ReverseString(string str)
        {
            return new string(ArrayProblems<char>.ReverseArray(str.ToCharArray()));
        }
        /// <summary>
        /// finds and returns first duplicate character in string
        /// </summary>
        /// <param name="arr">array of items</param>
        /// <returns>first duplicate item</returns>
        public static char FindDuplicate(string str)
        {
            Tuple<string, char> result = ArrayProblems<char>.FindDuplicate(str.ToCharArray());
            return result.Item1 == "found" ? result.Item2 : ' ';
        }

        public static bool IsPalindrome(string str)
        {
            int i = 0;
            for (; i<str.Length; i++)
            {
                
                if(i < ((str.Length - 1) - i))
                {
                    if(str[i] != str[str.Length - 1 - i])
                    {
                        return false;
                    }
                }
                else return true;
            }
            return true;
        }
    }
}
