using System;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    public static class LIS
    {
        /// <summary>
        /// A simple method to take a sequence of numbers and returns longest increasing sequeance
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string GetLongestIncreasingSubsequence(string input)
        {

            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            var stringArray = input.Split(Constants._delimeter);

            if (stringArray.Length == 1)
                return stringArray[0];

            if (!AreAllIntegers(stringArray))
                return string.Empty;


            return string.Empty;
        }

        /// <summary>
        /// A method to make sure all values in sequence are numbers
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static Boolean AreAllIntegers(string[] input)
        {
            foreach (var value in input)
            {
                bool isInteger = int.TryParse(value, out int i);

                if (!isInteger)
                    return false;
            }

            return true;
        }

    }
}
