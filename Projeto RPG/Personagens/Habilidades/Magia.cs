using Projeto_RPG.Personagens.Habilidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Habilidades
{
    internal class Magia : Habilidade
    {
        public int Custo { get; set; }

        public Magia(string nome, Tipos tipo, Tipos fraqueza, Efeito efeito, int dano, int custo) : base(nome, tipo, fraqueza, efeito, dano)
        {
            Custo = custo;
        }
    }
}
