using Projeto_RPG.Habilidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Habilidades
{
    internal class Habilidade
    {
        public string Nome { get; set; }
        public Tipos Tipo { get; set; }
        public Tipos Fraqueza { get; set; }
        public Efeito Efeito { get; set; }

        public int Dano { get; set; }

        public Habilidade(string nome, Tipos tipos, Tipos fraqueza, Efeito efeito,int dano)
        {
            this.Nome = nome;
            this.Tipo = tipos;
            this.Fraqueza = fraqueza;
            this.Efeito = efeito;
            this.Dano = dano;
        } 

        


        
         

    }
}
