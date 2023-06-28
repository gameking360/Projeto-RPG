using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
            Magias = null;
        }

        //Criação dos inimigos, eles são criados com tipos aleatórios, e vão sendo criados conforme o nível do jogador
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
                inimigos.Add(new Inimigo("Elfo", 30, 30, 10, 15, (Tipos)r.Next(1, 5), 10));    
                inimigos.Add(new Inimigo("Orc", 40, 40, 30, 30,(Tipos) r.Next(1,5),15));
            }
            if (player.Nivel == 3)
            {
                inimigos.Add(new Inimigo("Ent", 20, 20, 20, 20, Tipos.Grama, 10));
                inimigos.Add(new Inimigo("Elfo", 30, 30, 10, 15, (Tipos)r.Next(1, 5), 15));
                inimigos.Add(new Inimigo("Orc", 40, 40, 30, 30, (Tipos)r.Next(1, 5), 15));
                inimigos.Add(new Inimigo("Dragão", 60, 60, 50, 50, (Tipos)r.Next(1, 5), 20));
                inimigos.Add(new Inimigo("Golem", 60, 60, 30, 40, (Tipos)r.Next(1, 5), 15));
            }
            if (player.Nivel == 4)
            {
                inimigos.Add(new Inimigo("MUSTAFHAR", 100, 100, 75, 75, Tipos.Fogo, 1000)); //1000 de xp por causa do final da história
            }
            return inimigos;
            
            
        }

        //Criação dos Efeitos que as magias causam
        public static List<Efeito> CriacaoEfeitos()
        {
            List<Efeito> efeitos = new List<Efeito>();
            efeitos.Add(new Efeito("Envenenado", 1, 15));
            efeitos.Add(new Efeito("Fraqueza", 1, 0.30));
            efeitos.Add(new Efeito("Queimado", 2, 20));
            efeitos.Add(new Efeito("Congelado", 1, 0));
            efeitos.Add(new Efeito("Sangramento", 2, 20));

            return efeitos;
        }

        //Criação das Magias do Mundo
        public static List<Magia> CriacaoMagia(Personagem player)
        {
            
            List<Efeito> Efeitos = CriacaoEfeitos();
            List<Magia> Magia = new List<Magia>();
            Magia.Clear();

            if (player.Nivel == 1)
            {
                Magia.Add(new Magia("Bola de Fogo", Tipos.Fogo, Tipos.Gelo, Efeitos.Find(p => p.Nome == "Queimado"), 10, 10));
            }
            if (player.Nivel == 2)
            {
                Magia.Add(new Magia("Bola de Fogo", Tipos.Fogo, Tipos.Gelo, Efeitos.Find(p => p.Nome == "Queimado"), 10, 10));
                Magia.Add(new Magia("Piso de Gelo",Tipos.Gelo, Tipos.Eletricidade,Efeitos.Find(p => p.Nome == "Congelado"),12,20));
                Magia.Add(new Magia("Bolha de Agua", Tipos.Água, Tipos.Fogo, Efeitos.Find(p => p.Nome == "Fraqueza"), 10, 25));
            }
            if (player.Nivel == 3)
            {
                Magia.Add(new Magia("Bola de Fogo", Tipos.Fogo, Tipos.Gelo, Efeitos.Find(p => p.Nome == "Queimado"), 10, 10));
                Magia.Add(new Magia("Piso de Gelo", Tipos.Gelo, Tipos.Eletricidade, Efeitos.Find(p => p.Nome == "Congelado"), 12, 20));
                Magia.Add(new Magia("Bolha de Agua", Tipos.Água, Tipos.Fogo, Efeitos.Find(p => p.Nome == "Fraqueza"), 10, 25));
                Magia.Add(new Magia("Magia de cura", Tipos.Grama, Tipos.Nulo, null, 0, 35));
            }
            if (player.Nivel == 4)
            {
                Magia.Add(new Magia("Bola de Fogo", Tipos.Fogo, Tipos.Gelo, Efeitos.Find(p => p.Nome == "Queimado"), 10, 10));
                Magia.Add(new Magia("Piso de Gelo", Tipos.Gelo, Tipos.Eletricidade, Efeitos.Find(p => p.Nome == "Congelado"), 12, 20));
                Magia.Add(new Magia("Bolha de Agua", Tipos.Água, Tipos.Fogo, Efeitos.Find(p => p.Nome == "Fraqueza"), 10, 25));
                Magia.Add(new Magia("Magia de cura", Tipos.Grama, Tipos.Nulo, null, 80, 35));
                Magia.Add(new Magia("Relampagao", Tipos.Eletricidade, Tipos.Grama, null, 50 , 15));
            }

            return Magia;
        }

       
    }
}
