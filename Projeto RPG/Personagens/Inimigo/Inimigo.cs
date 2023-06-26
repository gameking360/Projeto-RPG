using Projeto_RPG.Personagens.Classes;
using Projeto_RPG.Personagens.Habilidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Personagens.Inimigo
{
    
    internal class Inimigo : Personagem
    {

        public  Tipos Tipo { get; set; }
        public int RecompensaXP { get; set; }
        public List<Inimigo> Inimigos { get; set; }

        public Inimigo(string nome, int pontosVidaAtual, int pontosVidaMax, int forca, int defesa, Tipos tipo, int recompensaXP)
        {
            Nome = nome;
            Classe = "Inimigo";
            PontosVidaAtual = pontosVidaAtual;
            PontosVidaMax = pontosVidaMax;
            Forca = forca;
            Defesa = defesa;
            Tipo = tipo;
            RecompensaXP = recompensaXP;
        }

        public override void Atacar(Personagem inimigo)
        {
            Console.WriteLine($"{this.Nome} ataca {inimigo.Nome}.");
            Console.ReadKey();
            Random r = new Random();

            int dano = CalcularDano(inimigo);

            if(inimigo is Arqueiro)
            {
                Arqueiro arq = (Arqueiro)inimigo;
                if (r.Next(1, 100) < (10 + (arq.Destreza / 10)))
                {
                    Console.WriteLine($"{Nome} errou o ataque.");
                    return; 
                }
                if (dano < 0)
                {
                    inimigo.PontosVidaAtual -= r.Next(1, 5) * 3;
                }

                else
                {
                    inimigo.PontosVidaAtual -= dano * 2;

                }
                if (inimigo.PontosVidaAtual < 0) inimigo.PontosVidaAtual = 0;
            }
            else
            {
                if (r.Next(1, 100) <= 10)
                {
                    Console.WriteLine($"{Nome} errou o ataque.");
                    return;
                }
                if (dano < 0)
                {
                    inimigo.PontosVidaAtual -= r.Next(1, 5) * 3;
                }

                else
                {
                    inimigo.PontosVidaAtual -= dano * 2;

                }

                if (inimigo.PontosVidaAtual < 0) inimigo.PontosVidaAtual = 0;
            }
                

        }

        public override void UsarHabilidade(Personagem inimigo)
        {
            base.UsarHabilidade(inimigo);
        }

        public override void Defender()
        {
            base.Defender();
        }

        public override void Status()
        {
            Console.WriteLine($"Nome: {Nome} \nVida: {PontosVidaAtual}/{PontosVidaMax}");
            
        }
        public override void VerEfeitos()
        {
            base.VerEfeitos();
        }
    }
}
