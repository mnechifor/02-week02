using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class CommonElementsOfArray
    {
        //Find common elements between two arrays of integers. 
        /// 1 4 5 7 82 3 5
        /// 4 4 7 3 32 4 7 9

        public static int[] Duplicates(int[] arr1, int[] arr2)
        {
            var count = FindNumberOfDuplicates(arr1, arr2);

            int[] result = new int[count];
            count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        result[count++] = arr1[i];
                        break;
                    }
                }
            }

            return result;
        }

        private static int FindNumberOfDuplicates(int[] arr1, int[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }
    }
}
