using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Personagem
    {
        public string Nome { get; set ; }
        public int PontosVida { get; set ; }
        public int Forca { get; set ; }
        public int Defesa { get; set ; }

        public Personagem() { }

        public void Atacar() {  }
        public void Fugir() { }
        public void Defender() { }
        public void UsarHabilidade() { }



    }
}
