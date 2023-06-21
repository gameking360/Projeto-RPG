using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Guerreiro : Personagem
    {
        public override string Nome { get; set; }
        public override int PontosVida { get; set; }
        public override int Forca { get; set; }
        public override int Defesa { get; set; }
        public int Destreza { get; set; }

        public Guerreiro(string nome)
        {
            Nome = nome;
            PontosVida = 100;
            Forca = 50;
            Defesa = 50;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }
    }
}
