using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class LeastCommonMultipleTest
    {
        private readonly LeastCommonMultiple _leastCommonMultiple;

        public LeastCommonMultipleTest()
        {
            _leastCommonMultiple = new LeastCommonMultiple();
        }

        [Theory]
        [InlineData(3, 7, 2, 42)]
        [InlineData(12, 24, 28, 168)]
        [InlineData(12, 24, 48, 48)]
        [InlineData(1234, 1326, 888, 121085016)]
        [InlineData(12345, 54321, 55555, 2483651996565)]
        public void ReturnTheLeastCommonMultiple(double number1, double number2, double number3, double expected)
        {
            double result = _leastCommonMultiple.Find(number1, number2, number3);

            Assert.Equal(result, expected);
        }

        [Fact]
        public void ReturnAscOrderedList()
        {
            List<double> numbers = _leastCommonMultiple.createOrderedListOfNumbers(3, 7, 2);
            List<double> expectedNumbers = new List<double>(){2, 3, 7};
            Assert.Equal(expectedNumbers, numbers);
        }
    }
}