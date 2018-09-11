using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrimeFactors pf =  new PrimeFactors();

            Console.WriteLine("Nueva Evaluacion 25, 50, 72");
            int nextPrime = pf.GetNextPrime(4);
            Console.WriteLine("Resultado: " + nextPrime);
        }
    }
}
