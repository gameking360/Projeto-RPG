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

        public Personagem() { }

        public Personagem(string nome)
        {
            Nome = nome;
            
        }

        public abstract void Atacar();
        public abstract void Fugir();
        public abstract void Defender();
        public abstract void UsarHabilidade();
        public abstract void CalcularDano();

        
    }
}