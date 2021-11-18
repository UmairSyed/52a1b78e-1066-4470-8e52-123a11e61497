using LongestIncreasingSubsequence;
using NUnit.Framework;

namespace Test
{
    public class LongestIncreasingSubsequence
    {

        [TestCase("", "", Description = "Test Case 01")]
        public void Get_EmptyInputString_ReturnsEmptyOutputString(string input, string output)
        {
            Assert.AreEqual(output, LIS.GetLongestIncreasingSubsequence(input));
        }

        [TestCase("100", "100", Description = "Test Case 01")]
        public void Get_SingleInputString_ReturnsSameOutputString(string input, string output)
        {
            Assert.AreEqual(output, LIS.GetLongestIncreasingSubsequence(input));
        }

        [TestCase("ABC 123", "", Description = "Test Case 01")]
        public void Get_SpaceSeparatedAlphaNumericString_ReturnsEmptyOutputString(string input, string output)
        {
            Assert.AreEqual(output, LIS.GetLongestIncreasingSubsequence(input));
        }
    }
}