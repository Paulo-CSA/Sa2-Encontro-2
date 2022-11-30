using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncontroRemoto_2.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{texto}");
            for (var i = 0; i < 6; i++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }
            Console.ResetColor();
            Console.Clear();
        }
        public static void ParadaNoConsole(string txt)
        {
            Console.WriteLine(txt);
            Console.WriteLine($"Aperte ENTER para continuar:");
            Console.ReadLine();

        }
    }
}