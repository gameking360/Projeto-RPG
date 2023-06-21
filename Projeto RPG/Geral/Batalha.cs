
using Projeto_RPG.Personagens.Inimigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Geral
{
    internal class Batalha
    {
        Random rand = new Random();
        public static void Combate(Personagem per, Inimigo inimigo)
        {
            
            string n = "";
            int p = 0;
            int v = 0;
            
            n = inimigo.Nome;
            p = inimigo.Forca;
            v = inimigo.PontosVidaMax;

            while (v > 0)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("| (A)tacar   (D)efender;       |");
                Console.WriteLine("| (F)ugir    (U)sar Habilidade |");
                Console.WriteLine("=======================================");
                Console.WriteLine($"Vida: {per}");
                string acao = Console.ReadLine();
                if (acao.ToLower() == "a" || acao.ToLower() == "Atacar")
                {
                    per.Atacar();
                }
                else if (acao.ToLower() == "d" || acao.ToLower() == "Defender")
                {
                    per.Defender();
                }
                else if (acao.ToLower() == "f" || acao.ToLower() == "Fugir")
                {
                    per.Fugir();
                }
                else if (acao.ToLower() == "u" || acao.ToLower() == "Usar Habilidade")
                {
                    per.UsarHabilidade();
                }
            }
        }
    }
}
       