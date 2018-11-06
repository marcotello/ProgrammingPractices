using System;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            var feet = 5280;
            var inches = 63360;
            
            Converter converter = new Converter(feet, inches);
            double result = converter.MilesToFeet(4.5);

            Console.WriteLine(result);
        }
    }
}
