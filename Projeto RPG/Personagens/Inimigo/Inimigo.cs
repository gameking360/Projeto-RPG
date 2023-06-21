using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Inimigo
{
    internal class Inimigo : Personagem
    {
        public override string Nome { get; set; }
        public override int PontosVida { get; set; }
        public override int Forca { get; set; }
        public override int Defesa { get; set; }
        public  string Tipo { get; set; }
        public int RecompensaXP { get; set; }

        public Inimigo(string nome, int pontosvida, int forca, int defesa, string tipo, int recompensaXP)
        {
            Nome = nome;
            PontosVida = pontosvida;
            Forca = forca;
            Defesa = defesa;
            Tipo = tipo;
            RecompensaXP = recompensaXP;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }
    }
}
