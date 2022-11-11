using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            // Exemplo 1
            bool isStudent = true;
            // Exemplo 2
            bool isAlmada1 = true;
            bool isStudent1 = true;
            // Exemplo 3
            bool isAlmada2 = false;
            bool isStudent2 = false;
            // Exemplo 4
            bool isAlmada3 = true;
            bool isStudent3 = true;
            // If Statements - Exemplo 1
            // if (condição)
            if (isStudent)
            {
                Console.WriteLine("És um estudante.");
            }
            else
            {
                Console.WriteLine("Não és um estudante.");
            }
            // If Statements - Exemplo 2
            if (isAlmada1 && isStudent1) // && = and
            {
                Console.WriteLine("És estudante de Almada.");
            } 
            else {
                Console.WriteLine("Não és estudante não és de Almada, ou ambos.");
            }
            // If Statements - Exemplo 3
            if (isAlmada2 || isStudent2) // || = or
            {
                Console.WriteLine("És um estudante ou és de Almada ou ambos.");
            } 
            else
            {
                Console.WriteLine("Não és um estudante de Almada.");
            }
            // If Statements - Exemplo 4
            if (isAlmada3 && isStudent3) // && = and
            {
                Console.WriteLine("És estudante de Almada."); // T/T
            }
            else if (isAlmada3 && !isStudent3) // ! = negação
            {
                Console.WriteLine("És de Almada mas não és estudante."); // T/F
            }
            else if (!isAlmada3 && isStudent3)
            {
                Console.WriteLine("És um estudante e não és de Almada."); // F/T
            }
            else
            {
                Console.WriteLine("Não és estudante e não és de Almada."); //F/F
            }
            // ReadLine
            Console.ReadLine();
        }
    }
}
