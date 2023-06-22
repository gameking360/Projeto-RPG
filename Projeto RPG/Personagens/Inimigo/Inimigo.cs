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

        public override void Defender()
        {
            Defesa += Forca/2;
        }

        public override void CalcularDano(Personagem atacado)
        {
            Random r = new Random();

            int dano = (int)((double)Forca * (1 + r.NextDouble()));
            int critico = r.Next(1, 20);

            if(critico == 20)
            {
                dano += (int) (0.5 *  (double) dano);
            }

            int dano_final = dano - atacado.Defesa;
            
        }
    }
}
