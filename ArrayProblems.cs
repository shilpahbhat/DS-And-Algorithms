using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Helper
{
    class ArrayProblems<T>
    {
        /// <summary>
        /// reverses an array, alternate to Array.Reverse()
        /// time complexity - O(n/2), space complexity - O(1)
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>reversed array</returns>
        public static T[] ReverseArray(T[] arr)    // [9,5,3,-7]
        {
            int i = 0;
            int j = arr.Length - 1;                     //3
            while (i < j)                               //0<3, 1<2
            {
                var temp = arr[i];                      //9 , 5
                arr[i] = arr[j];                        //-7, 3
                arr[j] = temp;                          //9, 3
                i++;                                    //1, 2
                j--;                                    //2,1
            }
            return arr;
        }
        /// <summary>
        /// finds and returns first duplicate item in array
        /// time complexity - O(n), space complexity - O(n)
        /// </summary>
        /// <param name="arr">array of items</param>
        /// <returns>first duplicate item</returns>
        public static Tuple<string,T> FindDuplicate(T[] arr)
        {
            HashSet<T> set = new HashSet<T>();
            foreach (T item in arr)
            {
                if (set.Contains(item))
                {
                    return new Tuple<string, T>("found",  item ) ;
                }
                else
                {
                    set.Add(item);
                }
            }

            return new Tuple<string, T>("not found", default(T));
        }
        /// <summary>
        /// find and returns all repeated items in array
        /// time complexity - O(n) and space complexity - O(n)
        /// </summary>
        /// <param name="arr">array of items</param>
        /// <returns>array of duplicate item</returns>
        public static HashSet<T> FindAllDuplicate(T[] arr)
        {
            HashSet<T> set = new HashSet<T>();
            HashSet<T> result = new HashSet<T>();
            foreach (T item in arr)
            {
                if (set.Contains(item))
                {
                    if(!result.Contains(item))
                    result.Add(item);
                }
                else
                {
                    set.Add(item);
                }
            }
            return result;

        }
        /// <summary>
        /// find first non repeated item in array
        /// </summary>
        /// <param name="arr">array of items</param>
        /// <returns>first non repeated item</returns>
        public static T FindNonRepeated(T[] arr)
        {
            Hashtable table = new Hashtable();
          
            foreach (T item in arr)
            {
                if (table.Contains(item))
                {
                    table[item]= Convert.ToInt32((int)table[item] + 1);
                }
                else
                {
                    table[item] = 1;
                }
            }
            Console.WriteLine(table.OfType<DictionaryEntry>().Where(s=> (int)s.Value == 1).First());
            return default(T);
        }
        /// <summary>
        /// find all non-repeated items in array
        /// </summary>
        /// <param name="arr">array of items</param>
        /// <returns>array of non-repeated items</returns>
        public static T[] FindAllNonRepeated(T[] arr)
        {
            return null;
        }
    }
}
