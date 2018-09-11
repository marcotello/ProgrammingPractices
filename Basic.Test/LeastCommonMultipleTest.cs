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
        public void ReturnTheLeastCommonMultiple(double number1, double number2, double number3, double expected)
        {
            double result = _leastCommonMultiple.Find(number1, number2, number3);

            Assert.Equal(result, expected);
        }

        [Theory]
        [MemberData(nameof(ReturnAscOrderedArrayData))]
        public void ReturnAscOrderedArray(double value1, double value2, double value3, double[] expectedNumbers)
        {
            double[] numbers = _leastCommonMultiple.createOrderedArrayOfNumbers(value1, value2, value3);
            Assert.Equal(expectedNumbers, numbers);
        }

        public static IEnumerable<object[]> ReturnAscOrderedArrayData()
        {

            return new List<object[]>
                {
                    new object[] { 3, 5, 2, new double[] { 2, 3, 5 } },
                    new object[] { -4, -6, -10, new double[] { -10, -6, -4 } },
                    new object[] { -2, 2, 0, new double[] { -2, 0, 2 } },
                    new object[] { -324, 324, 5444, new double[] { -324, 324, 5444 } }
                };
        }

        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(7, true)]
        [InlineData(12, false)]
        [InlineData(-43, false)]
        [InlineData(-1, false)]
        [InlineData(43, true)]
        [InlineData(75, false)]
        [InlineData(97, true)]
        [InlineData(5333, true)]
        public void CheckIfNumberIsPrime(int number, bool expected)
        {
            bool result = _leastCommonMultiple.IsPrime(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(-20, 2)]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 5)]
        [InlineData(5, 7)]
        [InlineData(6, 7)]
        [InlineData(7, 11)]
        [InlineData(8, 11)]
        [InlineData(9, 11)]
        [InlineData(10, 11)]
        [InlineData(11, 13)]
        public void GetNextPrimeNumberTest(int prime, int nextPrime)
        {
            int result = _leastCommonMultiple.GetNextPrimeNumber(prime);
            Assert.Equal(nextPrime, result);
        }

        [Theory]
        [MemberData(nameof(InitializeArrayToMultiply))]
        public void multiplyNumbersInAListTest(int[] numbers, double expected)
        {
            double result = _leastCommonMultiple.multiplyNumbersInAList(numbers);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> InitializeArrayToMultiply()
        {

            return new List<object[]>
                {
                    new object[] { new int[] { 2, 3, 5 }, 30 },
                    new object[] { new int[] { -10, -6, -4 }, -240 },
                    new object[] { new int[] { -2, 0, 2 }, 0 },
                    new object[] { new int[] { -3, 32, -54 }, 5184 }
                };
        }
    }
}