using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            Random rnd = new Random();
            int golHolanda, golPorto;
            int pontHolanda = 0, pontPorto = 0;
            /*// Classificação
            Console.WriteLine("Grupa A\nHolanda\nEquador\nSenegal\nCatar\n");
            Console.WriteLine("Grupa B\nInglaterra\nGales\nEstados Unidos\nIrã\n");
            Console.WriteLine("Grupa C\nArabia Saudita\nMéxico\nPolónia\nArgentina\n");
            Console.WriteLine("Grupa D\nAustrália\nDinamarca\nFrança\nTunísia\n");
            Console.WriteLine("Grupa E\nCosta Rica\nAlemanha\nJapão\nEspanha\n");
            Console.WriteLine("Grupa F\nBélgica\nCanadá\nCroácia\nMarrocos\n");
            Console.WriteLine("Grupa G\nBrasil\nCamarões\nSérvia\nSuíça\n");
            Console.WriteLine("Grupa H\nGana\nCoreia do Sul\nPortugal\nUruguai");
            // Game*/
            golHolanda = rnd.Next(10);
            golPorto = rnd.Next(10);

            if(golHolanda > golPorto)
            {
                Console.WriteLine("Golo da Holanda");
                pontHolanda++;
            } else if(golHolanda == golPorto)
            {
                Console.WriteLine("Impate da Holanda e do Porto");
                pontHolanda++;
                pontPorto++;
            } else
            {
                Console.WriteLine("Golo do Porto");
                pontPorto++;
            }
            Console.WriteLine("Holanda Pontos:" + pontPorto, "\nPorto Pontos:" + pontPorto);
            // ReadLine
            Console.ReadLine();

        }
    }
}
