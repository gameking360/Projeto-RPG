using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_RPG.Personagens.Habilidades.Enums;
using Projeto_RPG.Personagens.Inimigo;

namespace Projeto_RPG.Geral
{
    internal class Mundo
    {
        
        public static  void Criacao()
        {
            Random r = new Random();

            // Tipos a = new Random(1,5);
            
            Inimigo i1 = new Inimigo("Dragão Bebê", 40, 40, 30, 30,(Tipos) r.Next(1,5),5);
            Inimigo i2 = new Inimigo("Dragão", 60, 60, 50, 50, (Tipos)r.Next(1, 5), 15);
            Inimigo i3 = new Inimigo("Rei dos Dragões", 100, 100, 75, 75, (Tipos)r.Next(1, 5), 30);
            i1.Inimigos = new List<Inimigo>();
            //os outros inimigos só são adicionados na lista após o personagem atingir um nível determinado


        }

        
    }
}
