using System.Collections.Generic;
using Xunit;

namespace Basic.Test
{
    public class PrimeFactorsTest
    {
        private readonly PrimeFactors _primeFactors;
        public PrimeFactorsTest()
        {
            _primeFactors = new PrimeFactors();
        }

        [Theory]
        [InlineData(4, "4 = 2 2")]
        [InlineData(24, "24 = 2 2 2 3")]
        [InlineData(59, "59 = 59")]
        [InlineData(1234567890, "1234567890 = 2 3 3 5 3607 3803")]
        public void FindPrimeFactors(double number, string expected)
        {
            string result = _primeFactors.FindPrimeFactors(number);
            Assert.Equal(expected, result);
        }

        [Theory]
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
        [InlineData(-1, false)]
        [InlineData(59, true)]
        public void CheckIfNumberIsPrime(int number, bool expected)
        {
            bool result = _primeFactors.IsPrime(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2)]       
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 5)]
        [InlineData(5, 7)]
        [InlineData(6, 7)]
        [InlineData(7, 11)]
        [InlineData(8, 11)]
        [InlineData(9, 11)]
        public void GetNextPrimeTest(int number, int nextPrime)
        {
            int result = _primeFactors.GetNextPrime(number);
            Assert.Equal(nextPrime, result);
        }

        [Theory]
        [MemberData(nameof(InitializeGetOutputTest))]
        public void GetOutputTest(double number, int[] primes, string expected)
        {
            string result = _primeFactors.GetOutput(number, primes);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> InitializeGetOutputTest()
        {

            return new List<object[]>
                {
                    new object[] { 24, new int[] { 2, 2, 2, 3 }, "24 = 2 2 2 3" },
                    new object[] { 59, new int[] { 59 }, "59 = 59" },
                    new object[] { 4, new int[] { 2, 2 }, "4 = 2 2" },
                    new object[] { 50, new int[] { 2, 5, 5 }, "50 = 2 5 5" }
                };
        }
    }
}