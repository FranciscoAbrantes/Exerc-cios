using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 7, 14, 18, 25, 62 };
            string[] players = new string[5]; // Guardar 5 valores

            Console.WriteLine(numbers[0]);

            numbers[1] = 900;

            Console.WriteLine(numbers[1]);

            //População Array
            players[0] = "Ronaldo";
            players[1] = "Messi";
            players[2] = "Mbappe";
            players[3] = "Neymar";
            players[4] = "Bruno Fernades";

            Console.WriteLine(players[4]);
            Array.ForEach(numbers, Console.WriteLine);

            //User Input para um valor do arrar
            Console.WriteLine("jogador");
            players[4] = Console.ReadLine();
            Console.WriteLine(players[4]);

            //ReadLine
            Console.ReadLine();
        }
    }
}