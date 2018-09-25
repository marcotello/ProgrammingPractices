using Xunit;

namespace Basic.Test
{
    public class BinariesTest
    {
        private readonly Binaries _binaries;
        public BinariesTest()
        {
            _binaries = new Binaries();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(6, 4)]
        [InlineData(2135, 14)]
        public void GetMaximunTest(int originalNumber, int expected)
        {
            int result = _binaries.GetMaximun(originalNumber);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, new int[] {1})]
        [InlineData(6, new int[] {2, 3, 2, 4})]
        [InlineData(20, new int[] {2, 4, 3, 4, 2, 6, 5, 6, 3, 5, 4})]
        public void GetConvinationsTest(int original, int[] expected)
        {
            int[] result = _binaries.GetConvinations(original);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] {1, 3, 2}, 3)]
        [InlineData(new int[] {2, 3, 2, 4}, 4)]
        [InlineData(new int[] {2, 4, 3, 4, 2, 6, 5, 6, 3, 5, 4}, 6)]
        public void GetMaximunValueTest(int[] convinations, int expected)
        {
            int result = _binaries.GetMaximunValue(convinations);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 3, 3)]
        [InlineData(15, 5, 6)]
        [InlineData(6, 0, 2)]
        public void GetTotalOfOnesTest(int firstNumber, int secondNumber, int expected)
        {
            int result = _binaries.GetTotalOfOnes(firstNumber, secondNumber);
            Assert.Equal(expected, result);
        }
    }
}