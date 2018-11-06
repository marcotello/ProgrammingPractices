using Xunit;

namespace Medium.Test
{
    public class ConverterTest
    {
        private readonly Converter _converter;
        private int Feet = 5280;
        private int Inches = 63360;

        public ConverterTest()
        {
            _converter = new Converter(Feet, Inches);
        }

        [Theory]
        [InlineData(4.5, 23760)]
        [InlineData(7.4, 39072)] 
        public void MilesToFeetTest(double miles, double expected)
        {
            double result = _converter.MilesToFeet(miles);
            Assert.Equal(expected, result);
        }   

        [Theory]
        [InlineData(4.5543, "288560.45")]
        [InlineData(7.42332, "470341.56")] 
        public void MilesToInchesTest(double miles, string expected)
        {
            string result = _converter.MilesToInches(miles);
            Assert.Equal(expected, result);
        }   
    }
}