using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assessment1
{
    public class Solution
    {
        public static int GetMissingDigitFromOrderedArray(int[] inputArr)
        {
            int ans = inputArr.Length + 1;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (inputArr[i] != i + 1)
                {
                    ans = i + 1;
                    break;
                }
            }
            return ans;
        }
        public static int GetMissingDigitFromUnorderedArray(int[] inputArr)
        {
            var ans = 0;
            for (int i = 1; i <= inputArr.Length + 1; i++)
            {
                bool found = false;
                foreach (int arrVal in inputArr)
                {
                    if (i == arrVal)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    ans = i;
                    break;
                }
            }
            return ans;
        }
    }
}
