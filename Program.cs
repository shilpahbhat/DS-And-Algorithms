using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            #region integer problems tests
            //test cases to be considered
            //1. 1,0,-1
            //2. huge value - int32 - 2147483647


            //int n = Int32.MinValue;
            //List<int> result = IntegerProblems.IntegerToDigitArray(n);
            //result.ForEach((item) => Console.WriteLine(item));

            //int n = -896;
            //List<int> result = IntegerProblems.IntegerToReversedDigitArray(n);
            //result.ForEach((item) => Console.WriteLine(item));



            //int start = 5, end = 8;
            //List<int> numbers = IntegerProblems.InclusiveRangeOfNumbers(start, end);
            //numbers.ForEach((item) => Console.WriteLine(item));
         
            int[] input = new int[] { -8, 7, 8, 9 };        //-8789
            Console.WriteLine(IntegerProblems.DigitArrayToInteger(input).ToString());

            //int n = 789;
            //Console.WriteLine(IntegerProblems.ReverseNumber(n));

            //int n = -58767872;
            //Console.WriteLine(IntegerProblems.NumberOfDigits(n));
            #endregion

            #region float problems
            //double n = -0.655555;
            //Console.WriteLine(FloatProblems.NumberOfDigitsInFloat(n));
            #endregion

            #region array problems tests
            //test cases
            //1. one element
            int[] oneEleArr = new int[] { 3 };
            //2. two element
            int[] twoEleArr = new int[] { 6, 2 };
            //3. empty array
            int[] emptyArr = new int[0];
            //4. element to be found at the end
            //5. element to be found at the beginning
            //6. normal array
            int[] normalArray = new int[] { 3, 6, 8, 2, 5, 1,4,3 };
            //6. repeated elements in array
            int[] repeatedArray = new int[] { 3, 3, 5, 5, 3 };
            //7. negative elements 
            int[] negativeArray = new int[] { -3, 4, -5, 0, 3 };
            //8. -1, 0 , 1 in array
            int[] oneZeroArray = new int[] { 0, 1, 0, -1, 1, 0 };
            //9. big elements
            int[] bigEleArray = new int[] {  2147483647, 2147483633, 2147483567, 2147482345, 2147483647 };
            //10. huge array
            int[] hugeArray = new int[] { -2,1,4,7,4,8,3,6,4,7, -2,1,4,7,4,8,3,6,4,7, -2,1,4,7,4,8,3,6,4,7, -2,1,
            4,7,4,8,3,6,4,7 };


            //ArrayProblems<int>.ReverseArray(hugeArray).ToList().ForEach(item => Console.WriteLine(item));
            //Tuple<string, int> result = ArrayProblems<int>.FindDuplicate(twoEleArr);
            //Console.WriteLine(result.Item1 == "found" ? result.Item2.ToString(): string.Empty);
            //ArrayProblems<int>.FindAllDuplicate(emptyArr).ToList().ForEach(item => Console.WriteLine(item));
            //ArrayProblems<int>.FindNonRepeated(repeatedArray);
            //.ToList().ForEach(item => Console.WriteLine(item));

            #endregion

            #region string problem tests
            //test cases
            //string largeString = "sgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghksgfsgfdhdfhgdgjfkjghk"; ;
            //string emptyString = string.Empty;
            // string duplicateCharString = "ghhhhhhhhhhhh";
            //string palinString = "abba";
            //string evenLengthString = "shilpabhat";
            //string oddlengthString = "foxpar";
            //string stringWithNumbers = "3545";

            //Console.WriteLine(StringProblems.ReverseString(largeString));
            //Console.WriteLine(StringProblems.FindDuplicate(oddlengthString));
            //Console.WriteLine(StringProblems.IsPalindrome(stringWithNumbers));
            #endregion
        }

    }
}
