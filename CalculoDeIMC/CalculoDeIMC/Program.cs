using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.Write("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altrua: ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso/(altura*altura);

            Console.WriteLine("IMC = " + imc);

            if (imc <= 18.5)
            {
                Console.WriteLine("Baixo Peso");
            } else if (imc >= 18.5 || imc <= 24.9) {
                Console.WriteLine("Peso Normal");
            } else if (imc >= 25 || imc <= 29.9) {
                Console.WriteLine("Excesso de Peso");
            } else if (imc >= 30)
            {
                Console.WriteLine("Obesidade");
            } else
            {
                Console.WriteLine("Obesidade Maxima");
            }
            
            Console.ReadLine();
        }
    }
}
