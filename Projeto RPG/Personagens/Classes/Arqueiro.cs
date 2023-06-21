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
            PontosVidaMax = 100;
            PontosVidaAtual = PontosVidaMax;
            Forca = 70;
            Defesa = 30;
            Destreza = 30;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }

        public override void CalcularDano() { }
    }
}
