using Projeto_RPG.Personagens.Classes;
using Projeto_RPG.Personagens.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal abstract class Personagem
    {
        public string Nome { get; set ; }
        public int PontosVidaAtual { get; set ; }
        public int PontosVidaMax { get; set ; }
        public int Forca { get; set ; }
        public int Defesa { get; set ; }
        public int Nivel { get; set ; }
        public int ExpAtual { get; set ; }
        public List<Efeito> Efeitos { get; set ; }
        public List<Habilidade> Habilidades { get; set ; }

        public Personagem() { }

        public Personagem(string nome)
        {
            Nome = nome;
            Efeitos = new List<Efeito>();
            Habilidades = new List<Habilidade>();
            ExpAtual = 0;
            Nivel = 1;
            
        }

        public virtual void Atacar(Personagem inimigo)
        {
            Console.WriteLine($"{this.Nome} ataca {inimigo.Nome}.");
            Console.ReadKey();
            Random r = new Random();

            int dano = CalcularDano(inimigo);

            if(r.Next(1,100) <= 10)
            {
                Console.WriteLine($"{Nome} errou o ataque.");
                return;
            }
            if(dano < 0)
            {
                inimigo.PontosVidaAtual -= r.Next(1, 5) * 3;
            }

            else
            {
                inimigo.PontosVidaAtual -= dano * 2;
                
            }
           
            if (inimigo.PontosVidaAtual < 0) inimigo.PontosVidaAtual = 0;

        }

        public virtual void Fugir(Personagem Inimigo) 
        {
            Random r = new Random();
            int fugir = r.Next(1,20);

            if(fugir > 16)
            {
                Console.WriteLine("Você conseguiu fugir sem nenhum arranhão.");
            }
            else if(fugir < 6)
            {
                Console.WriteLine("Você tenta fugir mas é pego por um ataque crítico");
                int dano = CalcularDano(Inimigo) * 2;
                if (dano < 0) dano = dano * -1;
                PontosVidaAtual -= dano;
            }
            else
            {
                Console.WriteLine("Você consegue fugir mas é pego de raspão por um ataque");
                double dano = CalcularDano(Inimigo) * 0.50;
                if (dano < 0) dano = dano * -1;
                PontosVidaAtual -= (int)dano;
            }
            Console.ReadKey();
        }

        public virtual void Defender()
        {
            Console.WriteLine($"{Nome} defendeu");
            Defesa +=  Forca / 2;
            
        }

        public virtual void UsarHabilidade(Personagem inimigo)
        {

        }

        public virtual int CalcularDano(Personagem atacado)
        {
            Random r = new Random();

            int dano = (int)((double)Forca * (1 + r.NextDouble()));
            int critico = r.Next(1, 20);

            if (critico == 20)
            {
                Console.WriteLine($"{Nome} deu um acertou crítico");
                Console.ReadKey();
                dano += (int)(0.5 * (double)dano);
            }

            int dano_final = dano - atacado.Defesa;
            return dano_final;
        }

        public virtual void SubirNivel() 
        { 
            if (ExpAtual >= 5 && ExpAtual < 35)
            {
                Nivel = 2;
                PontosVidaMax += 5;

                PontosVidaAtual = PontosVidaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50)
            {
                Nivel = 3;
            }
            if (ExpAtual >= 50)
            {
                Nivel = 4;
            }
        }

        public abstract void Status();

    }
}