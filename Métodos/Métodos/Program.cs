using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JogoBenfica("Brugge", 2);
            JogoBenfica("Liverpool", 3);
            JogoBenfica("Real Madrid", 4);

            Console.ReadLine();
        }

        static void JogoBenfica(string equipa, int pontos)
        {
            Console.WriteLine("O Benfica vai jogar contra o " + equipa + "e tem " + pontos + " de avanço");
        }
    }
}
