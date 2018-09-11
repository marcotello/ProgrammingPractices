using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Fraction  fraction =  new Fraction();

            Console.WriteLine("Nueva Evaluacion 25, 50, 72");
            bool result = fraction.IsPrime(9);
            Console.WriteLine("Resultado: " + result);
        }
    }
}
