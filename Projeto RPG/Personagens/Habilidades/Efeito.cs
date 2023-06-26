using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Habilidades
{
    internal class Efeito
    {
        public string Nome { get; set; }

        public int RodadasAfetadas { get; set; }

        public double Quantidade { get; set; }

        public Efeito(string nome, int rodadas, double quantidade)
        {
            Nome = nome;
            RodadasAfetadas = rodadas;
            Quantidade = quantidade;
        }

    }
}
