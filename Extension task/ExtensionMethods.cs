using System;
using System.Collections.Generic;
using System.Text;

namespace Extension_task
{
    static class ExtensionMethods
    {
        
        public static bool IsEven(this int even)
        {
            if (even % 2 == 0)
            
                    return true;
            return false;
        }

        public static int[] GetValueIndexes(this int[] arr, int a)
        {
            int[] indexes = { };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    Array.Resize(ref indexes, indexes.Length+1);
                    indexes[indexes.Length - 1] = i;
                    return indexes;
                }
                
                
            }
            return indexes;


        }
      
        public static bool IsOdd(this int odd)
        {
            if (odd % 2 == 1)

                return true;
            return false;
        }

        public static bool IsContainsDigit(string str)
        {
            bool checkDigit = false;
            foreach (var item in str)
            {
                if (char.IsDigit(item))
                {
                    checkDigit = true;
                    return checkDigit;
                }
            }
            return checkDigit;

        }
        public static int[] GetValueIndexes(this string str, char b)
        {
            int[] newArr = { };
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == b)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = i;
                }
            }
            return newArr;

        }
    }
}
