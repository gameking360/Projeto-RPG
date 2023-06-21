using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Guerreiro : Personagem
    {
        public Guerreiro(string nome) : base (nome)
        {
            Nome = nome;
            PontosVidaMax = 100;
            PontosVidaAtual = PontosVidaMax;
            Forca = 50;
            Defesa = 50;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }

        public override void CalcularDano() { }
    }
}
