using Xunit;

namespace Basic.Test
{
    public class BiggerNumberTest
    {
        private readonly BiggerNumber _biggerNumber;

        public BiggerNumberTest()
        {
            _biggerNumber = new BiggerNumber();
        }

        [Theory]
        [InlineData(27, 3002, 3002)]
        [InlineData(3002, 28, 3002)]
        [InlineData(3002, 3002, 3002)]
        [InlineData(-500, -101, -101)]
        public void ReturnTheBiggestNumber(double number1, double number2, double expected)
        {
            // arrange
            
            // act
            double result = _biggerNumber.getBiggerNumber(number1, number2);
            
            // assert
            Assert.Equal(result, expected);
        }
    }
}