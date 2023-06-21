using Projeto_RPG.Personagens.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Jogo
    {
        public Jogo() { }
        public void IniciarJogo()
        {
            CriarPersonagem();
        }

        public void CriarPersonagem()
        {
            Console.WriteLine("Qual será o nome do seu personagem?");
            string nome = Console.ReadLine();
            bool check = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha a sua classe:");
                Console.WriteLine("|============|");
                Console.WriteLine("|1. Guerreiro|");
                Console.WriteLine("|2. Arqueiro |");
                Console.WriteLine("|  3. Mago   |");
                Console.WriteLine("|============|");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Guerreiro guerreiro = new Guerreiro(nome);
                        check = true;
                        break;
                    case 2:
                        Arqueiro arqueiro = new Arqueiro(nome);
                        check = true;
                        break;
                    case 3:
                        Mago mago = new Mago(nome);
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.ReadKey();
                        break;
                }
            } while (!check);
            Console.WriteLine("Personagem criado com sucesso!");

        }
    }
}
