using System;
using tabuleiro;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            p = new(3, 4);
            Console.WriteLine("Posição:"+p);
            Console.ReadLine();
        }
    }
}