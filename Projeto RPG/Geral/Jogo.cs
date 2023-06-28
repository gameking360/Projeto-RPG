using Projeto_RPG.Geral;
using Projeto_RPG.Personagens.Classes;
using Projeto_RPG.Personagens.Habilidades.Enums;
using Projeto_RPG.Personagens.Inimigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Jogo
    {
        private Historia Historia;
        private Mundo Mundo;
        private Random R;

        public Jogo() 
        {            
            Mundo = new Mundo();
            R = new Random();
        }

        public Jogo(Mundo mundo)
        {
            Historia = new Historia();
            Mundo = new Mundo();
            R = new Random();
        }

        public void IniciarJogo()
        {
            int op = 0;
            Console.Clear();
            Personagem player = CriarPersonagem();
            Historia.HisIntroducao(player);
            while (player.PontosVidaAtual > 0 && op != 3) op = Menu(player, op);
        }

        public int Menu(Personagem player, int op)
        {

            do
            {
                Console.Clear(); 
                Console.WriteLine("           MENU         ");
                Console.WriteLine("|========================|");
                Console.WriteLine("|  1. Batalhar           |");
                Console.WriteLine("|  2. Ver status         |");
                Console.WriteLine("|  3. Sair para o início |");
                Console.WriteLine("|========================|");
                switch (Console.ReadLine())

                {
                    case "1":
                        
                        Mundo.Inimigos = Mundo.CriacaoInimigos(player);
                        Batalha batalha = new Batalha(player, Mundo.Inimigos[R.Next(Mundo.Inimigos.Count)]);
                        batalha.IniciarCombate(); 
                        if(player.PontosVidaAtual == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("VOCÊ MORREU");                           
                            Historia.Creditos();
                            op = 2;
                        }
                        if(player.PontosVidaAtual > 0 && player.ExpAtual > 1000) //é 1000 pra garantir que só apareça o final
                        {                                                        //da história depois de matar o boss
                            Historia.HisFinal(player);
                            Historia.Creditos();
                            Historia.PosCreditos(player);
                        }
                        break;
                    case "2":
                        player.Status();
                        break;
                    case "3":
                        op = 3;
                        return op;
                        
                    default:
                        Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                        Console.ReadKey();
                        break;
                }
            } while (op < 1 || op > 3);
            return 0;
        }

        public Personagem CriarPersonagem()
        {
            Personagem player = new teste("Criar");
            Console.WriteLine("Criação do Personagem:");
            Console.WriteLine("Qual será o nome do seu personagem?");
            string nome = Console.ReadLine();
            bool check = false;
            do
            {
                Console.Clear();
                Console.WriteLine($"Escolha a classe de {nome}:");
                Console.WriteLine("|====================|");
                Console.WriteLine("|  1. Guerreiro      |");
                Console.WriteLine("|  2. Arqueiro       |");
                Console.WriteLine("|  3. Mago           |");
                Console.WriteLine("|====================|");
                switch (Console.ReadLine())
                {
                    case "1":
                        player = new Guerreiro(nome); // cria guerreiro
                        check = true;
                        break;
                    case "2":
                        player = new Arqueiro(nome); // cria arqueiro
                        check = true;
                        break;
                    case "3":
                        player = new Mago(nome); // cria mago
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                        Console.ReadKey();
                        break;
                }
            } while (!check);
            
            Console.WriteLine($"{nome} criado com sucesso!");
            return player;
        }

    }
}
