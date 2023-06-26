using System;
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
            Defesa = 30;
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
            if (CalcularDano(inimigo) < 0)
            {
                inimigo.PontosVidaAtual -= r.Next(1, 5) * 3;
            }

            else
            {
                inimigo.PontosVidaAtual -= this.CalcularDano(inimigo);

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
            base.SubirNivel();
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
