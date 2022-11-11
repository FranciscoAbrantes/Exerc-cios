using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoresNaIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade <= 17)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sem Permissão");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Com permissão");
            }

            Console.ReadLine();
        }
    }
}
