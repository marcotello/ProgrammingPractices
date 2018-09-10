using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LeastCommonMultiple lcm =  new LeastCommonMultiple();

            Console.WriteLine("Nueva Evaluacion 2");
            lcm.GetNextPrimeNumber(2);
            Console.WriteLine("Nueva Evaluacion 3");
            lcm.GetNextPrimeNumber(3);
            Console.WriteLine("Nueva Evaluacion 4");
            lcm.GetNextPrimeNumber(4);
            Console.WriteLine("Nueva Evaluacion");
            lcm.GetNextPrimeNumber(5);
            Console.WriteLine("Nueva Evaluacion");
            lcm.GetNextPrimeNumber(7);
            Console.WriteLine("Nueva Evaluacion");
            lcm.GetNextPrimeNumber(75);
            Console.WriteLine("Nueva Evaluacion");
            lcm.GetNextPrimeNumber(89);
        }
    }
}
