using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira seus dados e veja seu índice de massa corporal (IMC).");

            Console.Write("Altura em metros: ");
            string h = Console.ReadLine();
            double altura = Convert.ToDouble(h);

            Console.Write("Massa em quilogramas (peso): ");
            string m = Console.ReadLine();
            double massa = Convert.ToDouble(m);

            double result = Math.Pow(altura, 2);
            double resultfinal = massa / result;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O índice de massa corporal em questão é " + resultfinal + " kg/m².");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;



        }
    }
}
