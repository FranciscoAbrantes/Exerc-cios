using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoDeMétodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conversão dos Int
            Console.Write("Digite um numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite mais um número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // Receber o resultado do Metodo
            Console.WriteLine(GetMax(num1, num2, num3));

            // ReadLine
            Console.ReadLine();
        }

        // Metodo
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }
            return result;
        }
    }
}
