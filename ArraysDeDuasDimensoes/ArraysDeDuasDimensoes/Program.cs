using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDeDuasDimensoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
               {1, 2}, // 1 = colona 0; 2 = coluna 1
               {3, 4},
               {5, 6}
            };

            Console.WriteLine(numberGrid[2, 1]);

            //int[,] myArray = new int [1, 2];

            int[,,] array3D = new int[,,]
            {
                {
                    { 1, 2, 3 }, { 4, 5, 6 }
                },

                {
                    { 7, 8, 9 }, { 10, 11, 12 }
                }
            };
            Console.WriteLine(array3D[1, 0, 1]);

            int[,,,] array4D = new int[,,,]
            {
                {
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 }
                    },
                    {
                        { 7, 8, 9 },
                        { 10, 11, 12 }
                    }
                },
                {
                    {
                        { 13, 14, 15 },
                        { 16, 17, 18 }
                    },
                    {
                        { 19, 20, 21 },
                        { 22, 23, 24 }
                    }
                }
            };
            Console.WriteLine(array4D[1, 1, 0, 1]);

            Console.ReadLine();
        }
    }
}
