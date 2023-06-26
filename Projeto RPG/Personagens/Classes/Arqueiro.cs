﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Arqueiro : Personagem
    {
        public int Destreza { get; set; }

        public Arqueiro(string nome) : base(nome)
        {
            Nome = nome;
            PontosVidaMax = 90;
            PontosVidaAtual = PontosVidaMax;
            Forca = 0;
            Defesa = 15;
            Destreza = 30;
        }

        public override void Atacar(Personagem inimigo)
        {
            Console.WriteLine($"{this.Nome} ataca {inimigo.Nome}.");
            Console.ReadKey();
            Random r = new Random();
            
            if (r.Next(1, 100) <= (10 - (Destreza/10)))
            {
                Console.WriteLine($"{Nome} errou o ataque.");
                return;
            }
            int dano = CalcularDano(inimigo);
          
            if (dano < 0)
            {
                inimigo.PontosVidaAtual -= r.Next(1, 5) * 3;
            }

            else
            {
                inimigo.PontosVidaAtual -= dano;

            }
            if (inimigo.PontosVidaAtual < 0) inimigo.PontosVidaAtual = 0;
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

        public override void SubirNivel() 
        {
            if (ExpAtual >= 5 && ExpAtual < 35 && Nivel != 2)
            {
                Nivel = 2;
                PontosVidaMax += 10;
                Forca += 5;
                Defesa += 3;
                Destreza += 10;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50 && Nivel != 3)
            {
                Nivel = 3;
                PontosVidaMax += 15;
                Forca += 5;
                Defesa += 5;
                Destreza += 10;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 50)
            {
                Nivel = 4;
                PontosVidaMax += 20;
                Forca += 7;
                Defesa += 8;
                Destreza += 10;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
        }

        public override void Status() 
        {
            Console.WriteLine("=====================");
            Console.WriteLine($" Nome: {Nome}. Arqueiro nível {Nivel}");
            Console.Write("Vida:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{PontosVidaAtual}/{PontosVidaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Destreza:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{Destreza}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("=====================");
            Console.Write("\nPressione qualquer tecla para continuar");
            Console.ReadKey();
                
            





        }
    }
}
