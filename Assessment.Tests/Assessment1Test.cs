using Assessment1;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Assessment.Tests
{
    public class Assessment1Test
    {
        public static IEnumerable<object[]> GetOrderedInputArrays()
        {
            var testData = new List<object[]>();
            int[] seedArray = GenerateArray(100);
            Random rng = new Random();
            int randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).ToArray(),
                randomMissingNumber
            });

            randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).ToArray(),
                randomMissingNumber
            });

            randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).ToArray(),
                randomMissingNumber
            });

            testData.Add(new object[]
            {
                seedArray.Where(x => x != 100).ToArray(),
                100
            });
            return testData;
        }

        public static IEnumerable<object[]> GetUnorderedInputArrays()
        {
            var testData = new List<object[]>();
            int[] seedArray = GenerateArray(100);
            Random rng = new Random();
            int randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).OrderBy(x => rng.Next()).ToArray(),
                randomMissingNumber
            });

            randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).OrderBy(x => rng.Next()).ToArray(),
                randomMissingNumber
            });

            randomMissingNumber = rng.Next(1, 100);
            testData.Add(new object[]
            {
                seedArray.Where(x => x != randomMissingNumber).OrderBy(x => rng.Next()).ToArray(),
                randomMissingNumber
            });

            testData.Add(new object[]
            {
                seedArray.Where(x => x != 100).OrderBy(x => rng.Next()).ToArray(),
                100
            });
            return testData;
        }
        public static int[] GenerateArray(int count)
        {
            int[] arr = new int[count];
            for (int i = 1; i <= count; i++)
            {
                arr[i - 1] = i;
            }
            return arr;
        }

        [Theory]
        [MemberData(nameof(GetOrderedInputArrays))]
        public void TestOrderedArrays(int[] inputArray, int missingNumber)
        {
            var ans = Solution.GetMissingDigitFromOrderedArray(inputArray);
            Assert.Equal(missingNumber, ans);
        }

        [Theory]
        [MemberData(nameof(GetUnorderedInputArrays))]
        public void TestUnorderedArrays(int[] inputArray, int missingNumber)
        {
            var ans = Solution.GetMissingDigitFromUnorderedArray(inputArray);
            Assert.Equal(missingNumber, ans);
        }
    }
}
