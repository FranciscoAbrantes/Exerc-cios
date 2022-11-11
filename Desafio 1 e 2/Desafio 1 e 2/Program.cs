using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1_e_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Desafio 1
            Console.WriteLine("Insere um múmero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O numero é impare");
            }
            else
            {
                Console.WriteLine("O numero não é impare");
            }
            // Desafio 2
            string[] frutas = new string[4];

            frutas[0] = "Banana";
            frutas[1] = "Maça";
            frutas[2] = "Morangos";
            frutas[3] = "Laranja";

            Console.Write("Digite um destes 4 frutas que tu preferes.\n1- Banana\n2- Maça\n3- Morangos\n4- Laranja\nR: ");
            frutas[1] = Console.ReadLine();
            Console.WriteLine(frutas[1]);

            // ReadLine
            Console.ReadLine();
        }
    }
}
