using Projeto_RPG.Personagens.Habilidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Inimigo
{
    internal class Inimigo : Personagem
    {
        public  Tipos Tipo { get; set; }
        public int RecompensaXP { get; set; }
        public List<Inimigo> Inimigos { get; set; }

        public Inimigo(string nome, int pontosVidaAtual, int pontosVidaMax, int forca, int defesa, Tipos tipo, int recompensaXP)
        {
            Nome = nome;
            PontosVidaAtual = pontosVidaAtual;
            PontosVidaMax = pontosVidaMax;
            Forca = forca;
            Defesa = defesa;
            Tipo = tipo;
            RecompensaXP = recompensaXP;
        }

        public override void Atacar() { }

        public override void UsarHabilidade() { }

        public override void Defender() { }

        public override void Fugir() { }

        public override void CalcularDano() { }
    }
}
