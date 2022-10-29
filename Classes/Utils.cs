using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FS11__UC12_ER2.Classes
{
    static class Utils
    {
        public static void BarraCarregamento(string texto, int qtdPontinhos, int tempo)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;//cor de fundo
            Console.ForegroundColor = ConsoleColor.White;//cor da fonte
            Console.Write($"{texto} ");

            for (int contador = 1; contador <= qtdPontinhos; contador++)
            {
                Console.Write(".");
                Thread.Sleep(tempo);//aguarda meio segundo
            }
            Console.ResetColor();//volta as cores de fundo e fonte para o padrão
            System.Console.WriteLine();//pular uma linha
        }

        public static void ParadaNoConsole(string txt)
        {
            //fazer parada no sistema
            Console.WriteLine(txt);
            Console.Write($"Tecle ENTER para continuar ...");
            Console.ReadLine();

        }


    }
}