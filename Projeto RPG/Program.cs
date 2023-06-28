using Projeto_RPG.Geral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Program
    {
        public static void Main()
        {
            Mundo mundo = new Mundo();
            Jogo jogo = new Jogo(mundo);
            Historia historia = new Historia();
            Tutorial tutorial = new Tutorial();
            Console.Title = "LEGENDS OF MUSTAFHAR";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("LEGENDS OF MUSTAFHAR!");
                Console.WriteLine("|===================|");
                Console.WriteLine("|  (1) Novo jogo    |");
                Console.WriteLine("|  (2) Tutorial     |");
                Console.WriteLine("|  (3) Créditos     |");
                Console.WriteLine("|  (4) Sair do jogo |");
                Console.WriteLine("|===================|");
                switch (Console.ReadLine())
                {
                    case "1": jogo.IniciarJogo();
                        break;
                    case "2": tutorial.TutorialMenu();
                        break;
                    case "3": Console.Clear(); 
                        historia.Creditos();
                        break;
                    case "4": flag = false;
                        Console.Clear();
                        Console.WriteLine("Fechando jogo...");
                        Console.WriteLine("3...");
                        Thread.Sleep(1000);
                        Console.WriteLine("2...");
                        Thread.Sleep(1000);
                        Console.WriteLine("1...");
                        Thread.Sleep(1000);
                        Console.WriteLine("Tchau! :)");
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