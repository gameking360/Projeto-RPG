using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class Mago : Personagem
    {
        public override string Nome { get; set; }
        public override int PontosVida { get; set; }
        public override int Forca { get; set; }
        public override int Defesa { get; set; }
        public int PontosMagia { get; set; }

        public Mago(string nome)
        {
            Nome = nome;
            PontosVida = 100;
            Forca = 30;
            Defesa = 30;
            PontosMagia = 100;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }
    }
}
