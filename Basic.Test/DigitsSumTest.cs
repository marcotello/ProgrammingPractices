using Xunit;

namespace Basic.Test
{
    public class DigitsSumTest
    {
        private readonly DigitsSum _digitSum;

        public DigitsSumTest()
        {
            _digitSum = new DigitsSum();
        }

        [Theory]
        [InlineData("3433", "3 + 4 + 3 + 3 = 13")]
        [InlineData("64323", "6 + 4 + 3 + 2 + 3 = 18")]
        [InlineData("8", "8 = 8")]
        [InlineData("-1", "")]
        public void SumDigitsTest(string digits, string expected)
        {
            string result = _digitSum.SumDigits(digits);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[]{3,4,3,3}, 13, "3 + 4 + 3 + 3 = 13")]
        [InlineData(new int[]{6,4,3,2,3}, 18, "6 + 4 + 3 + 2 + 3 = 18")]
        [InlineData(new int[]{8}, 8, "8")]
        public void PrintResultTest(int[] numbers, int sumResult, string expected)
        {
            string result = _digitSum.PrintResult(numbers, sumResult);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[]{3,4,3,3}, 13)]
        [InlineData(new int[]{6,4,3,2,3}, 18)]
        [InlineData(new int[]{8}, 8)]
        public void SumNumbersTest(int[] numbers, int expected)
        {
            int result = _digitSum.SumNumbers(numbers);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("3433", new int[]{3,4,3,3})]
        [InlineData("64323", new int[]{6,4,3,2,3})]
        [InlineData("8", new int[]{8})]
        [InlineData("-1", new int[]{})]
        public void GetNumbersTest(string digits, int[] expected)
        {
            int[] result = _digitSum.GetNumbers(digits);
            Assert.Equal(expected, result);
        }
        
    }
}