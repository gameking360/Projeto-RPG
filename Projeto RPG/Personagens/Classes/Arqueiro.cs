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
    internal class Arqueiro : Personagem
    {
        public int Destreza { get; set; }

        public Arqueiro(string nome) : base(nome)
        {
            Nome = nome;
            Classe = "Arqueiro";
            PontosVidaMax = 90;
            PontosVidaAtual = PontosVidaMax;
            Forca = 5;
            Defesa = 20;
            Destreza = 30;
            Habilidades.Add(new Habilidade("Flecha flamejante", Tipos.Fogo, Tipos.Gelo, Mundo.CriacaoEfeitos().Find(p => p.Nome == "Queimado"), (Destreza/2) + 5));
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
                PontosVidaMax += 15;
                Forca += 5;
                Defesa += 10;
                Destreza += 20;

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50 && Nivel != 3)
            {
                Nivel = 3;
                PontosVidaMax += 25;
                Forca += 5;
                Defesa += 15;
                Destreza += 20;
                Habilidades.Add(new Habilidade("Flecha envenenada", Tipos.Grama, Tipos.Água, Mundo.CriacaoEfeitos().Find(p => p.Nome == "Envenenado"), Destreza + 10));

                Console.WriteLine($"{Nome} subiu para o nivel {Nivel} e recuperou toda a vida");
                Console.WriteLine($"{Nome} desbloqueou a habilidade 'Flecha envenenada'!");
                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 50)
            {
                Nivel = 4;
                PontosVidaMax += 30;
                Forca += 7;
                Defesa += 25;
                Destreza += 40;

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
