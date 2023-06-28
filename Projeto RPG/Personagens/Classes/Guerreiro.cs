using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_RPG.Personagens.Habilidades;
using Projeto_RPG.Personagens.Habilidades.Enums;
using Projeto_RPG.Geral;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base(nome)
        {
            Nome = nome;
            Classe = "Guerreiro";
            PontosVidaMax = 150;
            PontosVidaAtual = PontosVidaMax;
            Forca = 15;
            Defesa = 25;
            Habilidades.Add(new Habilidade("Golpe de Espada", Tipos.Cortante, Tipos.Gelo, Mundo.CriacaoEfeitos().Find(p => p.Nome == "Sangramento"), 15));
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
            int critico = r.Next(1, 21);
            if (critico == 20)
            {
                
                Console.WriteLine($"{Nome} deu um acertou crítico");
                Console.ReadKey();
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
                Forca += 5;
                Defesa += 7;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50 && Nivel != 3)
            {
                Nivel = 3;
                PontosVidaMax += 25;
                Forca += 10;
                Defesa += 10;
                Habilidades.Add(new Habilidade("Espada Flamejante", Tipos.Fogo, Tipos.Gelo, Mundo.CriacaoEfeitos().Find (p => p.Nome == "Queimado") ,20));

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                Console.WriteLine($"{Nome} desbloqueou a habilidade 'Espada Flamejante'!");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 50 && Nivel != 4)
            {
                Nivel = 4;
                PontosVidaMax += 45;
                Forca += 18;
                Defesa += 25;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
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
            Console.WriteLine($" Exp atual: {ExpAtual}");
            Console.WriteLine("========================");
            Console.Write("\nPressione qualquer tecla para continuar");
            Console.ReadKey();

        }
    }
}