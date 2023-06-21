using Projeto_RPG.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Personagem
    {
        public string Nome { get; set ; }
        public int PontosVida { get; set ; }
        public int Forca { get; set ; }
        public int Defesa { get; set ; }

        public List<Habilidade> Habilidades { get; set ; }

        public Personagem() { }

        public Personagem(string nome, int pontosVida, int forca, int defesa, List<Habilidade> habilidades)
        {
            Nome = nome;
            PontosVida = pontosVida;
            Forca = forca;
            Defesa = defesa;
            Habilidades = habilidades;
        }

        public void Atacar() {  }
        public void Fugir() { }
        public void Defender() { }
        public void UsarHabilidade() { }


        public void AdicionarHabilidade(Habilidade habilidade)
        {
            this.Habilidades.Add(habilidade);
        }
    }
}
