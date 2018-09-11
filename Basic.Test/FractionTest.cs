using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class FractionTest
    {
        private readonly Fraction _fraction;
        public FractionTest()
        {
            _fraction = new Fraction();
        }

        [Theory]
        [InlineData(0.25, "1/4")]
        [InlineData(0.5, "1/2")]
        [InlineData(0.125, "1/8")]
        [InlineData(0.002, "1/500")]
        [InlineData(0.376, "47/125")]
        public void GetMinimumFractionTest(double number, string expected)
        {
            string result = _fraction.GetMinimumFraction(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(InitializeReduceFractionTest))]
        public void ReduceFractionTest(KeyValuePair<int, int> fraction, KeyValuePair<int, int> expected)
        {
            KeyValuePair<int, int> reducedFraction = _fraction.ReduceFraction(fraction);
            Assert.Equal(expected, reducedFraction);
        }

        public static IEnumerable<object[]> InitializeReduceFractionTest()
        {

            return new List<object[]>
                {
                    new object[] { new KeyValuePair<int, int>(25, 100), new KeyValuePair<int, int>(1, 4) },
                    new object[] { new KeyValuePair<int, int>(5, 10), new KeyValuePair<int, int>(1, 2) },
                    new object[] { new KeyValuePair<int, int>(125, 1000), new KeyValuePair<int, int>(1, 8) },
                    new object[] { new KeyValuePair<int, int>(2, 1000), new KeyValuePair<int, int>(1, 500) },
                    new object[] { new KeyValuePair<int, int>(376, 1000), new KeyValuePair<int, int>(47, 125) }
                };
        }

        [Theory]
        [MemberData(nameof(InitializeGetFractionTest))]
        public void GetFranctionTest(double number, KeyValuePair<int, int> expected)
        {
            KeyValuePair<int, int> fraction = _fraction.GetFraction(number);
            Assert.Equal(expected, fraction);
        }

        public static IEnumerable<object[]> InitializeGetFractionTest()
        {

            return new List<object[]>
                {
                    new object[] { 0.25, new KeyValuePair<int, int>(25, 100) },
                    new object[] { 0.5, new KeyValuePair<int, int>(5, 10) },
                    new object[] { 0.125, new KeyValuePair<int, int>(125, 1000) },
                    new object[] { 0.002, new KeyValuePair<int, int>(2, 1000) },
                    new object[] { 0.376, new KeyValuePair<int, int>(376, 1000) }
                };
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void CheckIfIsPrime(int number, bool expected)
        {
            bool result = _fraction.IsPrime(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(-1, 2)]
        [InlineData(3, 5)]
        [InlineData(4, 5)]
        [InlineData(6, 7)]
        [InlineData(7, 11)]
        [InlineData(8, 11)]
        public void GetNextPrimeTest(int number, int nextPrime)
        {
            int result = _fraction.GetNextPrime(number);
            Assert.Equal(nextPrime, result);
        }
    }
}