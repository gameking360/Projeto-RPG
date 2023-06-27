
using Projeto_RPG.Personagens.Inimigo;
using System;
using Projeto_RPG.Personagens.Habilidades.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_RPG.Personagens.Habilidades;
using Projeto_RPG.Personagens.Classes;

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
                    if(Player is Mago)
                    {
                        Mago m = (Mago)Player;
                        Console.WriteLine($"Mana: {m.PontosMagiaAtual}/{m.PontosMagiaMax}");
                    }
                    Console.WriteLine("|==================================|");
                    if (Player.Classe != "Mago") Console.WriteLine("| 1. Atacar     2. Usar Habilidade |");
                    else Console.WriteLine("| 1. Atacar     2. Usar Magia      |");
                    Console.WriteLine("| 3. Defender   4. Fugir           |");
                    Console.WriteLine("|==================================|");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Player.Atacar(Inimigo);
                            op = 3;
                            break;
                        case "2":if(Player.Classe == "Mago")
                            { Mago mago = (Mago)Player;
                                mago.Magias = Mundo.CriacaoMagia(mago);
                                Magias();
                            }
                            else {
                                Player.UsarHabilidade(Inimigo);
                            }
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
                if (Inimigo.PontosVidaAtual > 0) AcaoInimigo();
            }
            if (Player.PontosVidaAtual > 0)
            {
                Console.Clear();
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

            Inimigo.VerEfeitos();
            if(Inimigo.EfeitoSofrido != null &&Inimigo.EfeitoSofrido.Nome == "Congelado")
            {
                Console.WriteLine($"{Inimigo.Nome} está congelado");
                return;
            }

            int acao = rand.Next(1, 2);
            switch (acao)
            {
                case 1: 
                    Inimigo.Atacar(Player);
                    break;
                case 2:
                    Inimigo.Defender();
                    break;
            }
        }
       

        public void Magias()
        {
            do
            {
            int x = 1;
            Mago m = (Mago)Player;
            Console.WriteLine("Digite a magia a ser usada");
            Console.WriteLine("====================");

            foreach (Magia me in m.Magias)
            {
                Console.WriteLine($"{x} - {me.Nome} - {me.Custo}");
                x++;
            }
            Console.WriteLine("====================");

            
                string magia = Console.ReadLine().ToLower();

                if (m.Magias.Exists(ma => ma.Nome.ToLower() == magia))
                {
                    
                    Magia magia1 = m.Magias.Find(p => p.Nome.ToLower() == magia);
                    

                    m.UsarMagia(Inimigo, magia1);
                    break;
                }
                else
                {
                    Console.WriteLine("Digite um nome de magia que você possua");
                    
                }
            } while (true);
        }
    }
}
       