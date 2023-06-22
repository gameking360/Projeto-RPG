using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Classes
{
    internal class teste : Personagem
    {

        public teste(string nome) : base(nome)
        {
            Nome = nome;
            Forca = 30;
            Defesa = 30;
            PontosVidaMax = 100;
            PontosVidaAtual = PontosVidaMax;

        }

        public override void Atacar(Personagem inimigo)
        {
            base.Atacar(inimigo);
        }

        public override int CalcularDano(Personagem atacado)
        {
            return base.CalcularDano(atacado);
        }

        public override void Defender()
        {
            base.Defender();
        }

        public override void Fugir(Personagem Fujao)
        {
            base.Fugir(Fujao);
        }

        public override void UsarHabilidade(Personagem inimigo)
        {
            base.UsarHabilidade(inimigo);
        }

        public override void Status()
        {
            throw new NotImplementedException();    
        }

        public override void SubirNivel() { }
    }
}
