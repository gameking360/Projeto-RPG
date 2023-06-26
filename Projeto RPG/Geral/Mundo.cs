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
        
        public List<Inimigo> Inimigos { get; set; } = new List<Inimigo> { };
        public List<Efeito> Efeitos { get; set; }
        public List<Magia> Magias { get; set; }
        
        public Mundo()
        {
            Inimigos = null;
            Efeitos = CriacaoEfeitos();
            Magias = CriacaoMagia();
        }

        public static List<Inimigo> CriacaoInimigos(Personagem player)
        {
            Random r = new Random();

            List<Inimigo> inimigos = new List<Inimigo>();
            inimigos.Clear();
            
            if (player.Nivel == 1)
            {
                inimigos.Add(new Inimigo("Dragão Bebê", 10, 10, 5, 0, (Tipos)r.Next(1, 5), 5));
            }
            if (player.Nivel == 2)
            {
                inimigos.Add(new Inimigo("Dragão Bebê", 10, 10, 5, 0, (Tipos)r.Next(1, 5), 5));
                inimigos.Add(new Inimigo("Ent", 20, 20, 20, 20, Tipos.Grama, 10));
                inimigos.Add(new Inimigo("Elfo", 30, 30, 10, 15, (Tipos)r.Next(1, 5), 15));    
                inimigos.Add(new Inimigo("Orc", 40, 40, 30, 30,(Tipos) r.Next(1,5),15));
            }
            if (player.Nivel == 3)
            {
                inimigos.Add(new Inimigo("Dragão Bebê", 10, 10, 5, 0, (Tipos)r.Next(1, 5), 5));
                inimigos.Add(new Inimigo("Ent", 20, 20, 20, 20, Tipos.Grama, 10));
                inimigos.Add(new Inimigo("Elfo", 30, 30, 10, 15, (Tipos)r.Next(1, 5), 15));
                inimigos.Add(new Inimigo("Orc", 40, 40, 30, 30, (Tipos)r.Next(1, 5), 15));
                inimigos.Add(new Inimigo("Dragão", 60, 60, 50, 50, (Tipos)r.Next(1, 5), 20));
                inimigos.Add(new Inimigo("Mini Golem", 60, 60, 30, 40, (Tipos)r.Next(1, 5), 15));
            }
            if (player.Nivel == 4)
            {
                inimigos.Add(new Inimigo("MUSTAFHAR", 100, 100, 75, 75, Tipos.Fogo, 1000)); //1000 de xp por causa do final da história
            }
            return inimigos;
            
            
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

        public static List<Magia> CriacaoMagia()
        {
            
            List<Efeito> Efeitos = CriacaoEfeitos();
            List<Magia> Magia = new List<Magia>();
            Magia.Add(new Magia("Bola de Fogo", Tipos.Fogo, Tipos.Água,Efeitos.Find(p => p.Nome == "Queimado"), 10, 10));
            Magia.Add(new Magia("Piso de Gelo",Tipos.Gelo, Tipos.Fogo,Efeitos.Find(p => p.Nome == "Congelado"),12,20));
            Magia.Add(new Magia("Bolha de Agua", Tipos.Água, Tipos.Grama,Efeitos.Find(p => p.Nome == "Fraqueza"),10,25));
            Magia.Add(new Magia("Magia de cura", Tipos.Grama, Tipos.Nulo, null, 0, 35));
            Magia.Add(new Magia("Relampagao", Tipos.Eletricidade, Tipos.Nulo, null, 25, 15));

            return Magia;
        }

        /*public static List<Habilidade> HabilidadesGuerreiro()
        {
            List<Habilidade> HabGuerreiro = new List<Habilidade>();


        }*/


    }
}
