using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aula 18/10/2022
            // String
            string nome = "Francisco";
            // Int
            int idade = 17;
            // Double
            double media = 17.1;
            // Bool
            bool isCorrect = true;
            // Char
            char inicial = 'A';
            // WriteLine
            Console.WriteLine("A minha idade " + idade);
            Console.WriteLine(nome);
            Console.WriteLine(media);
            Console.WriteLine(isCorrect);
            Console.WriteLine(inicial);
            // Aula 25/10/2022
            // Metos (Função)
            string student = "o aluno teve vinte";
            Console.WriteLine(student.Length); // Indica o número de letras a string contem.
            Console.WriteLine(student.ToUpper()); //Coloca a string toda em maiscula
            Console.WriteLine(student.Contains("aluno")); //Verifica se contem o parâmetro, o que esta parênteses.
            // Index
            Console.WriteLine(student[13]); // Vai indicar o index pedido da string, o que está entre [].
            Console.WriteLine(student.IndexOf("teve")); // Indica o index da palavra pedida, neste caso vai ser o index 8.
            // Sub-String
            Console.WriteLine(student.Substring(8)); // Vai ler tudo a partir do index 8.
            Console.WriteLine(student.Substring(8, 4)); // O index 8 é onde começa e o index 4 é o nº caracters amostrar
            // ReadLine
            Console.ReadLine();
        }
    }
}
