using Projeto_RPG.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mundo mundo = new Mundo();
            Jogo jogo = new Jogo(mundo);
            Historia historia = new Historia();
            Console.Title = "LEGENDS OF MUSTAFHAR";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("LEGENDS OF MUSTAFHAR!");
                Console.WriteLine("=====================");
                Console.WriteLine("|  (1) Novo jogo    |");
                Console.WriteLine("|  (2) Créditos     |");
                Console.WriteLine("|  (3) Sair do jogo |");
                Console.WriteLine("=====================");
                switch (Console.ReadLine())
                {
                    case "1": jogo.IniciarJogo();
                        break;
                    case "2": Console.Clear(); 
                        historia.Creditos();
                        break;
                    case "3": flag = false;
                        Console.Clear();
                        Console.WriteLine("Fechando jogo...");
                        Thread.Sleep(1500);
                        
                        break;
                    default: Console.Clear();
                        Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                        Console.ReadKey();
                        break;
                }
            }
            Console.Clear();
        }
    }
}