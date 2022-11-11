using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicio
            Console.WriteLine();
            Console.WriteLine("- Mad Lib -");
            Console.WriteLine();
            // Perguntas
            // Primeira Pergunta
            Console.WriteLine("What came first, the chicken or the ________?");
            Console.Write("Respond: ");
            string chicken = Console.ReadLine();
            Console.WriteLine();
            // Segunda Pergunta
            Console.WriteLine("This is a result from a Math exercise, 24.");
            Console.WriteLine("What is easy way to get to the result with multiply?");
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second and final number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            // Resultados e Respostas
            // Primeira Pergunta
            Console.WriteLine("What came first, the chicken or the " + chicken + "?");
            Console.WriteLine("If you respond with 'the egg', then your correct!");
            Console.Write("The egg came first because they where around way before chickens existed.");
            Console.WriteLine();
            //Segunda Pergunta
            Console.WriteLine("Result " + num1 * num2);
            Console.WriteLine("If you pick up 2 and 7, your correct!");
            // ReadLine
            Console.ReadLine();
        }
    }
}
