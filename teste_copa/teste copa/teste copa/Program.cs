using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_copa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bem vido ao simulador da copa do mundo");
            Console.WriteLine("grupo A");
            Console.WriteLine("~~~~~~P~~G~~GS");
            Console.Write("Catar: ");
            Console.WriteLine(Catarp());
            Console.Write("Equator: ");
            Console.WriteLine(equadorp());
            Console.Write("Senegal: ");
            Console.WriteLine(senegalp());
            Console.Write("Paises baixos: ");
            Console.WriteLine(paisesbaixosp());
            Console.WriteLine("~~~~~~~~~~~~~~");
            Console.WriteLine("Grupo B");
            Console.Write("Inglaterra: ");
            Console.WriteLine(inglaterrap());
            Console.Write("Estados Unidos: ");
            Console.WriteLine(usap());
            Console.Write("Irão: ");
            Console.WriteLine(irap());
            Console.Write("Pais de Gales: ");
            Console.WriteLine(galesp());
            Console.WriteLine("~~~~~~~~~~~~");
            Console.WriteLine("Grupo C");
            Console.Write("Argentina: ");
            Console.WriteLine(argentinap());
            Console.Write("Mexico: ");
            Console.WriteLine(mexicop());
            Console.Write("Arabia Saudita: ");
            Console.WriteLine(arabiap());
            Console.Write("Polonia: ");
            Console.WriteLine(poloniap());
            Console.WriteLine("~~~~~~~~~~~~");
            Console.WriteLine("Grupo D");
            Console.Write("Frença: ");
            Console.WriteLine(francap());
            Console.Write("Australia: ");
            Console.WriteLine(autraliap());
            Console.Write("Tunisia: ");
            Console.WriteLine(tunisiap());
            Console.Write("Dinamarca: ");
            Console.WriteLine(dinamarcap());
            Console.WriteLine("Grupo E");
            Console.WriteLine("~~~~~~~~~~~~");
            Console.Write("Japao: ");
            Console.WriteLine(japaop());
            Console.Write("Espanha: ");
            Console.WriteLine(espanha());
            Console.Write("Alemanha: ");
            Console.WriteLine(alemanha());
            Console.WriteLine();
            Console.WriteLine(" Grupo H ");
            Console.WriteLine("~~~~~~P~~G~~GS");

            // Grupo A
            if (Catarp() > equadorp())
            {
                PontMet("Catar", "Equator", 1, 0);
            }
            else if (Catarp() == equadorp())
            {
                PontMet("Catar", "Equator", 1, 1);
            }
            else
            {
                PontMet("Catar", "Equator", 0, 1);
            }
            if (senegalp() > paisesbaixosp())
            {
                PontMet("Senegal", "Paises Baixos", 1, 0);
            }
            else if (senegalp() == paisesbaixosp())
            {
                PontMet("Senegal", "Paises Baixos", 1, 1);
            }
            else
            {
                PontMet("Senegal", "Paises Baixos", 0, 1);
            }

            // Grupo B
            if (inglaterrap() > usap())
            {
                PontMet("Inglaterra", "Estados Unidos", 1, 0);
            }
            else if (inglaterrap() == usap())
            {
                PontMet("Inglaterra", "Estados Unidos", 1, 1);
            }
            else
            {
                PontMet("Inglaterra", "Estados Unidos", 0, 1);
            }
            if (irap() > galesp())
            {
                PontMet("Irão", "Pais de Gales", 1, 0);
            }
            else if (irap() == galesp())
            {
                PontMet("Irão", "Pais de Gales", 1, 1);
            }
            else
            {
                PontMet("Irão", "Pais de Gales", 0, 1);
            }

            Console.ReadLine();
        }


        static Random numgolos = new Random();//chamar para gols 

        static int Catarp()
        {

            if (numgolos.Next() < 0.93)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.93 && numgolos.Next() < 0.94)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 0.95)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.96)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.96 && numgolos.Next() < 0.97)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.97 && numgolos.Next() < 0.98)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.98 && numgolos.Next() < 1)
            {
                return 6;

            }


            return numgolos.Next(0, 6);



        }

        static int equadorp()
        {
            if (numgolos.Next() < 0.75)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.75 && numgolos.Next() < 0.85)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.85 && numgolos.Next() < 0.90)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.90 && numgolos.Next() < 0.93)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.93 && numgolos.Next() < 0.95)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.97)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.97 && numgolos.Next() < 1)
            {
                return 6;

            }


            return numgolos.Next(0, 6);

        }
        static int senegalp()
        {
            if (numgolos.Next() < 0.75)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.75 && numgolos.Next() < 0.85)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.85 && numgolos.Next() < 0.90)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.90 && numgolos.Next() < 0.93)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.93 && numgolos.Next() < 0.95)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.97)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.97 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int paisesbaixosp()
        {
            if (numgolos.Next() < 0.45)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.45 && numgolos.Next() < 0.63)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.63 && numgolos.Next() < 0.76)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.91)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.91 && numgolos.Next() < 0.94)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static int inglaterrap()
        {
            if (numgolos.Next() < 0.34)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.34 && numgolos.Next() < 0.60)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.60 && numgolos.Next() < 0.76)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.91)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.91 && numgolos.Next() < 0.94)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);
        }
        static int usap()
        {
            if (numgolos.Next() < 0.85)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.85 && numgolos.Next() < 0.90)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.90 && numgolos.Next() < 0.93)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.93 && numgolos.Next() < 0.97)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.97 && numgolos.Next() < 0.986)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.986 && numgolos.Next() < 0.997)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.997 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static int irap()
        {
            if (numgolos.Next() < 0.86)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.86 && numgolos.Next() < 0.89)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.89 && numgolos.Next() < 0.94)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 0.982)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.982 && numgolos.Next() < 0.993)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.993 && numgolos.Next() < 0.995)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.995 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static int galesp()
        {
            if (numgolos.Next() < 0.89)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.89 && numgolos.Next() < 0.94)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 0.98)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.98 && numgolos.Next() < 0.986)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.986 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);
        }
        static int argentinap()
        {
            if (numgolos.Next() < 0.34)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.34 && numgolos.Next() < 0.65)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.65 && numgolos.Next() < 0.78)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.78 && numgolos.Next() < 0.90)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.90 && numgolos.Next() < 0.98)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static int mexicop()
        {
            if (numgolos.Next() < 0.34)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.34 && numgolos.Next() < 0.79)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.79 && numgolos.Next() < 0.90)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.90 && numgolos.Next() < 0.964)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.964 && numgolos.Next() < 0.987)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.987 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static int arabiap()
        {
            if (numgolos.Next() < 0.89)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.89 && numgolos.Next() < 0.94)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.94 && numgolos.Next() < 0.98)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.98 && numgolos.Next() < 0.986)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.986 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int poloniap()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int francap()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int autraliap()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int tunisiap()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int dinamarcap()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int japaop()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int espanha()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }

        static int alemanha()
        {
            if (numgolos.Next() < 0.50)
            {
                return 0;

            }
            else if (numgolos.Next() >= 0.50 && numgolos.Next() < 0.76)
            {
                return 1;
            }
            else if (numgolos.Next() >= 0.76 && numgolos.Next() < 0.88)
            {

                return 2;
            }
            else if (numgolos.Next() >= 0.88 && numgolos.Next() < 0.95)
            {
                return 3;
            }
            else if (numgolos.Next() >= 0.95 && numgolos.Next() < 0.989)
            {
                return 4;

            }
            else if (numgolos.Next() >= 0.989 && numgolos.Next() < 0.990)
            {
                return 5;

            }
            else if (numgolos.Next() >= 0.990 && numgolos.Next() < 1)
            {
                return 6;

            }

            return numgolos.Next(0, 6);

        }
        static void PontMet(string metEquipPrime, string metEquipSeg, int metGolPrime, int metGolSeg)
        {
            int metPontPrim = 0;
            int metPontSeg = 0;
            if (metGolPrime > metGolSeg)
            {
                Console.WriteLine("Golo da " + metEquipPrime);
                metPontPrim = 3;
            }
            else if (metGolPrime == metGolSeg)
            {
                Console.WriteLine("Impate da " + metEquipPrime + "e do Porto " + metEquipSeg);
                metPontPrim = 1;
                metPontSeg = 1;
            }
            else
            {
                Console.WriteLine("Golo do " + metEquipSeg);
                metPontSeg = 3;
            }
            Console.WriteLine("Ponto da " + metEquipPrime + ": " + metPontPrim + "\n" + "Ponto da " + metEquipSeg + ": " + metPontSeg);
        }
    }
}
