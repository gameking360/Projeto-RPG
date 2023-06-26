
using Projeto_RPG.Personagens.Inimigo;
using System;
using Projeto_RPG.Personagens.Habilidades.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Geral
{
    internal class Batalha
    {
        public Personagem Player { get; set; }
        private Inimigo Inimigo { get; set; }
        Random rand = new Random();

        public Batalha(Personagem player,Inimigo inimigo)
        {
            Player = player;
            Inimigo = inimigo;
        }

        public void IniciarCombate()
        {
            int defesaPadrao = Player.Defesa;
            Console.Clear();
            int op = 0;
            while (Inimigo.PontosVidaAtual > 0 && Player.PontosVidaAtual > 0)
            {
                Player.Defesa = defesaPadrao;
                do
                {
                    Console.Clear();
                    Console.WriteLine($" {Player.Nome}: {Player.PontosVidaAtual}/{Player.PontosVidaMax} HP   VS.   {Inimigo.Nome}: {Inimigo.PontosVidaAtual}/{Inimigo.PontosVidaMax} HP");
                    Console.WriteLine("|==================================|");
                    Console.WriteLine("| 1. Atacar     2. Usar Habilidade |");
                    Console.WriteLine("| 3. Defender   4. Fugir           |");
                    Console.WriteLine("|==================================|");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Player.Atacar(Inimigo);
                            op = 3;
                            break;
                        case "2":
                            Player.UsarHabilidade(Player);
                            op = 3;
                            break;
                        case "3":
                            Player.Defender();
                            op = 3;
                            break;
                        case "4":
                            Player.Fugir(Inimigo);
                            op = 3;
                            return;
                        default:
                            Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                            Console.ReadKey();
                            op = 0;
                            break;
                    }
                } while (op < 1 || op> 4);

                AcaoInimigo();
            }
            if (Player.PontosVidaAtual > 0 && Player.Nivel < 4)
            {
                Console.WriteLine("Você venceu a batalha!");
                Console.WriteLine($"Você ganhou: {Inimigo.RecompensaXP} exp" );
                Player.ExpAtual = Player.ExpAtual + Inimigo.RecompensaXP;
                Console.WriteLine($"Exp atual: {Player.ExpAtual}");
                Player.SubirNivel();
                Console.ReadKey();
            }

            
        }

        public void AcaoInimigo()
        {
            int acao = rand.Next(1, 3);
            switch (acao)
            {
                case 1: 
                    Inimigo.Atacar(Player);
                    break;
                case 2:
                    Inimigo.Defender();
                    break;
                case 3:
                    Inimigo.UsarHabilidade(Player);
                    break;
            }
        }
    }
}
       