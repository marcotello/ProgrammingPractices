using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NewKing  newKing =  new NewKing();

            string[] kings = new string[] { "Felipe", "Carlos", "Felipe", "Felipe", "Felipe", "Carlos", "Felipe", "Carlos",
                        "Alfonso", "Alfonso", "JuanCarlos" };
            string[] newKings = new string[] { "Felipe", "Leonor", "Felipe" };

            Console.WriteLine("Nueva Evaluacion 25, 50, 72");

            string[] result = newKing.GetNextKing(kings, newKings);
            Console.WriteLine("Resultado: " + result);
        }
    }
}
