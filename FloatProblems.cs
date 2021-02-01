using System;
using System.Collections.Generic;
using System.Text;

namespace Helper
{
    class FloatProblems
    {
        /// <summary>
        /// gives the number of digits in an decimal number
        /// Time complexity : O(1)
        /// </summary>
        /// <param name="n">input number</param>
        /// <returns>number of digits</returns>
        public static int NumberOfDigitsInFloat(double d)
        {
            int length = d.ToString().Split('.')[0].Length + d.ToString().Split('.')[1].Length;
            return (d < 0) ? length - 1 : length;
        }
    }
}
