using Projeto_RPG.Personagens.Habilidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Habilidades
{
    internal class Habilidade
    {
        public string Nome { get; set; }
        public Tipos Tipo { get; set; }
        public Tipos Fraqueza { get; set; }
        public Efeito Efeito { get; set; }

        public int Dano { get; set; }

        public Habilidade(string nome, Tipos tipos, Tipos fraqueza, Efeito efeito, int dano)
        {
            Nome = nome;
            Tipo = tipos;
            Fraqueza = fraqueza; // Vantagem. Ex.: Tipo: Fogo -> Fraqueza: Gelo
            Efeito = efeito;
            Dano = dano;
        }
       
    }
}
