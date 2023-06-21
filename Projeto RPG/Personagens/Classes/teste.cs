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

        public override void Atacar()
        {
            throw new NotImplementedException();
        }

        public override void CalcularDano()
        {
            throw new NotImplementedException();
        }

        public override void Defender()
        {
            throw new NotImplementedException();
        }

        public override void Fugir()
        {
            throw new NotImplementedException();
        }

        public override void UsarHabilidade()
        {
            throw new NotImplementedException();
        }
    }
}
