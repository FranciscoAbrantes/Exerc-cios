using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetPower(4, 3));
            Console.ReadLine();
        }

        static int GetPower(int bas, int expoent)
        {
            int i;
            int result = 1;

            for (i = 0; i < expoent; i++)
            {
                result = result * bas;
            }
            return result;
        }
    }
}
