using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Mago : Personagem
    {        
        public int PontosMagia { get; set; }

        public Mago(string nome) : base(nome)
        {
            Nome = nome;
            PontosVidaMax = 100;
            PontosVidaAtual = PontosVidaMax;
            Forca = 30;
            Defesa = 30;
            PontosMagia = 100;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public void UsarMagia() { }

        public override void Defender() { }

        public override void Fugir() { }

        public override void CalcularDano(Personagem atacado) { }
    }
}
