using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal abstract class Personagem
    {
        public abstract string Nome { get; set ; }
        public abstract int PontosVida { get; set ; }
        public abstract int Forca { get; set ; }
        public abstract int Defesa { get; set ; }

        public Personagem() { }

        public abstract void Atacar();
        public abstract void Fugir();
        public abstract void Defender();
        public abstract void UsarHabilidade();



    }
}
