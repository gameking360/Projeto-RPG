
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
            while (Inimigo.PontosVidaAtual > 0 && Player.PontosVidaAtual > 0)
            {
                int op = 0;
                Player.Defesa = defesaPadrao;
                do
                {
                    Console.WriteLine($" {Player.Nome}: {Player.PontosVidaAtual}/{Player.PontosVidaMax} HP   VS.   {Inimigo.Nome}: {Inimigo.PontosVidaAtual}/{Inimigo.PontosVidaMax} HP");
                    Console.WriteLine("|==================================|");
                    Console.WriteLine("| 1. Atacar     2. Usar Habilidade |");
                    Console.WriteLine("| 3. Defender   4. Fugir           |");
                    Console.WriteLine("|==================================|");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Player.Atacar(Inimigo);
                            break;
                        case 2:
                            Player.UsarHabilidade(Player);
                            break;
                        case 3:
                            Player.Defender();
                            break;
                        case 4:
                            Player.Fugir(Inimigo);
                            op = 3;
                            return;
                        default:
                            Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                            Console.ReadKey();
                            break;
                    }
                } while (op < 1 || op> 4);

                AcaoInimigo();
            }
            if (Player.PontosVidaAtual > 0)
            {
                Console.WriteLine("Você venceu a batalha!");
                Console.WriteLine($"Você ganhou: {Inimigo.RecompensaXP} exp" );
                Player.ExpAtual = Player.ExpAtual + Inimigo.RecompensaXP;
                Console.WriteLine(Player.ExpAtual);
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
       