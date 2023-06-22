using Projeto_RPG.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mundo mundo = new Mundo();
            Jogo jogo = new Jogo(mundo);
            Console.Title = "LEGENDS OF MUSTAFHAR";
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            jogo.IniciarJogo();
            
            


            Console.ReadKey();
        }
    }
}