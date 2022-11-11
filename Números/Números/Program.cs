using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            int num = 2;
            // Inteiros
            // Soma
            Console.WriteLine(num+2);
            Console.WriteLine(num+num);
            Console.WriteLine(2+2);
            // Subtração
            Console.WriteLine(num-2);
            Console.WriteLine(num-num);
            Console.WriteLine(2-2);
            // Divisão
            Console.WriteLine(num/2);
            Console.WriteLine(num/num);
            Console.WriteLine(2/2);
            // Multiplicação
            Console.WriteLine(num*2);
            Console.WriteLine(num*num);
            Console.WriteLine(2*2);
            // Resto (Resto da Divisão)
            Console.WriteLine(num%2);
            Console.WriteLine(num%num);
            Console.WriteLine(2%2);
            // Regra de Calcular o Primeiro
            Console.WriteLine(4+2*3);
            Console.WriteLine((4+2)*3);
            // Casas Decimais
            // Soma
            Console.WriteLine(5.0+2.5);
            Console.WriteLine(5+2.5);
            // Divisão (Inteiro Vs. Casas Decimais)
            Console.WriteLine(5/2);
            Console.WriteLine(5/2.5);
            // Calculo das Variaveis
            //Soma
            Console.WriteLine(num);
            num--; // -1
            Console.WriteLine(num);
            num++; // +1
            Console.WriteLine(num);
            // Metos Matemático
            // Absoluto
            Console.WriteLine(Math.Abs(-40));
            // Potencia
            Console.WriteLine(Math.Pow(3,2));
            // Raiz Quadrada
            Console.WriteLine(Math.Sqrt(64));
            // Minimo
            Console.WriteLine(Math.Min(4,20));
            // Maximo
            Console.WriteLine(Math.Max(4,20));
            // Rondadentos
            Console.WriteLine(Math.Round(4.5, MidpointRounding.ToEven)); // Número inteiro par mais proximo
            Console.WriteLine(Math.Round(4.5, MidpointRounding.AwayFromZero)); // Número inteiro mais proximo distante de zero
            // ReadLine
            Console.ReadLine();
        }
    }
}
