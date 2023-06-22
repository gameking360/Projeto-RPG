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
        }

        public abstract void Atacar();
        public virtual void Fugir() { }
        public abstract void Defender();
        public abstract void UsarHabilidade();
        public abstract void CalcularDano(Personagem atacado);
        public abstract void SubirNivel();
        

    }
}