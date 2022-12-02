using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_e_objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro1 = new Livro();
            livro1.titulo = "Harry Potter";
            livro1.autor = "JK Rowling";
            livro1.paginas = 400;

            Livro livro2 = new Livro();
            livro2.titulo = "Senhor dos anéis";
            livro2.autor = "Sei la";
            livro2.paginas = 500;

            Console.WriteLine(livro1.paginas);
            Console.WriteLine(livro2.autor);

            Console.ReadLine();
        }
    }
}