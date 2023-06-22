using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Projeto_RPG.Personagens.Habilidades;
using Projeto_RPG.Personagens.Habilidades.Enums;
using Projeto_RPG.Personagens.Inimigo;

namespace Projeto_RPG.Geral
{
    internal class Mundo
    {
        
        public List<Inimigo> Inimigos { get; set; }
        public List<Efeito> Efeitos { get; set; }
        
        public Mundo()
        {
            Inimigos = CriacaoInimigos();
            Efeitos = CriacaoEfeitos();
        }

        public static List<Inimigo> CriacaoInimigos()
        {
            Random r = new Random();

            List<Inimigo> inimigos = new List<Inimigo>();
            
            inimigos.Add(new Inimigo("Dragão Bebê", 40, 40, 30, 30,(Tipos) r.Next(1,5),5));
            inimigos.Add(new Inimigo("Dragão", 60, 60, 50, 50, (Tipos)r.Next(1, 5), 15));
            inimigos.Add(new Inimigo("Rei dos Dragões", 100, 100, 75, 75, (Tipos)r.Next(1, 5), 30));
            inimigos.Add(new Inimigo("Zumbi", 10, 10, 5, 0, (Tipos)r.Next(1, 5), 5));
            inimigos.Add(new Inimigo("Mini Golem", 60, 60,30,40,(Tipos) r.Next(1,5),40));
            inimigos.Add(new Inimigo("Elfo", 30, 30, 10, 15, (Tipos)r.Next(1, 5), 20));
            inimigos.Add(new Inimigo("Orc", 20, 20, 20, 20, (Tipos)r.Next(1, 5), 15));

            return inimigos;
            
            //os outros inimigos só são adicionados na lista após o personagem atingir um nível determinado
        }

        public static List<Efeito> CriacaoEfeitos()
        {
            List<Efeito> efeitos = new List<Efeito>();
            efeitos.Add(new Efeito("Envenenado", "O personagem atingido sofre dano a cada rodada", 1, 1));
            efeitos.Add(new Efeito("Fraqueza", "O personagem atingido sofre 30% a mais de dano na próxima rodada", 1, 0.30));
            efeitos.Add(new Efeito("Queimado", "O personagem atingido queima por 2 rodadas", 2, -10));
            efeitos.Add(new Efeito("Congelado", "O personagem atingido fica 1 rodada sem agir", 1, 0));

            return efeitos;
        }
        
    }
}
