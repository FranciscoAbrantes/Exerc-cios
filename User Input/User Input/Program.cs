using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // User Input
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you're " + age);
            // ToInt32
            int num = Convert.ToInt32(2);
            Console.WriteLine(num + 2);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            // ToDouble
            Console.Write("Enter a number: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num3 + num4);
            // Calc
            Console.WriteLine("- Somar -");
            Console.Write("Insere um número: ");
            double soma1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insere mais um número: ");
            double soma2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(soma1 + soma2);

            Console.WriteLine("- Subtrarir -");
            Console.Write("Insere um número: ");
            double sub1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insere mais um número: ");
            double sub2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(sub1 - sub2);

            Console.WriteLine("- Multiplicar -");
            Console.Write("Insere um número: ");
            double mult1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Insere mais um número: ");
            double mult2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(mult1 * mult2);
            // ReadLine
            Console.ReadLine();
        }
    }
}
