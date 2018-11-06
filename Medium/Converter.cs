using System;
using System.Globalization;

namespace Medium
{
    public class Converter
    {
        public int FeetConvertionRate { get; set; }
        public int InchesConvertionRate { get; set; }

        public Converter(int _feetConvertionRate, int _inchesConvertionRate)
        {
            FeetConvertionRate = _feetConvertionRate;
            InchesConvertionRate = _inchesConvertionRate; 
        }

        public double MilesToFeet(double miles)
        {
            return miles * FeetConvertionRate;
        }

        public string MilesToInches(double miles)
        {
            double result = miles * InchesConvertionRate;
            return result.ToString("F", CultureInfo.InvariantCulture);
        }
    }
}