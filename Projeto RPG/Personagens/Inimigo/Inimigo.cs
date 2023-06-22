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

        public override void Atacar(Personagem inimigo)
        {
            base.Atacar(inimigo);
        }

        public override void UsarHabilidade(Personagem inimigo)
        {
            base.UsarHabilidade(inimigo);
        }

        public override void Defender()
        {
            base.Defender();
        }

        public override void Status()
        {
            Console.WriteLine($"Nome: {Nome} \nVida: {PontosVidaAtual}/{PontosVidaMax}");
            
        }
    }
}
