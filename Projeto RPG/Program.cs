using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();
            jogo.IniciarJogo();
            Console.ReadKey();
        }
    }
}
