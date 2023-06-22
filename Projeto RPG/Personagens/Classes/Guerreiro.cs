using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome)
        {
            Nome = nome;
            PontosVidaMax = 150;
            PontosVidaAtual = PontosVidaMax;
            Forca = 100;
            Defesa = 20;
        }

        public override void Atacar(Personagem inimigo)
        {
            base.Atacar(inimigo);
        }

        public override void UsarHabilidade(Personagem inimigo)
        {
            base.UsarHabilidade(inimigo);
        }

        public override void Defender()
        {
            base.Defender();
        }

        public override void Fugir(Personagem Fugitivo)
        {
            base.Fugir(Fugitivo);
        }

        public override int CalcularDano(Personagem atacado)
        {
            Random r = new Random();

            int dano = (int)((double)Forca * (1 + r.NextDouble()));
            int critico = r.Next(1, 20);

            if (critico == 20)
            {
                dano += dano;
            }

            int dano_final = dano - atacado.Defesa;
            return dano_final;
        }

        public override void SubirNivel() 
        {
            if (ExpAtual >= 5 && ExpAtual < 35 && Nivel != 2)
            {
                Nivel = 2;
                PontosVidaMax += 15;
                Forca += 3;
                Defesa += 5;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50 && Nivel != 3)
            {
                Nivel = 3;
                PontosVidaMax += 25;
                Forca += 5;
                Defesa += 7;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel}");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 50)
            {
                Nivel = 4;
                PontosVidaMax += 30;
                Forca += 7;
                Defesa += 8;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel}");
                PontosVidaAtual = PontosVidaMax;
            }
        }

        public override void Status()
        {
            Console.WriteLine("========================");
            Console.WriteLine($" Nome: {Nome}. Guerreiro nível {Nivel}");
            Console.Write($" Vida: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{PontosVidaAtual}/{PontosVidaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" Força: {Forca}");
            Console.WriteLine($" Exp atual {ExpAtual}");
            Console.WriteLine("========================");
            Console.ReadKey();

        }
    }
}