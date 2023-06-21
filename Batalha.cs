using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG
{
    internal class Batalha
    {
        public static void Combate(inimigo)
        {
            string n = "";
            int p = 0;
            int v = 0;
            
            n = inimigo.Nome;
            p = inimigo.Força;
            v = inimigo.PontosVida;

            while (v > 0)
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("| (A)tacar   (D)efender; |");
                Console.WriteLine("| (F)ugir    (U)sar Habilidade |");
                Console.WriteLine("=======================================");
                Console.WriteLine($"Vida: {Personagem.PontosVida}");
                string acao = Console.ReadLine();
                if (acao.ToLower() == "a" || acao.ToLower() == "Atacar")
                {
                    Personagem.Atacar();
                }
                else if(acao.ToLower() == "d" || acao.ToLower() == "Defender")
                {
                    Personagem.Defender();
                }
                else if(acao.ToLower() == "f" || acao.ToLower() == "Fugir")
                {
                    Personagem.Fugir();
                }
                else if(acao.ToLower() == "u" || acao.ToLower() == "Usar Habilidade")
                {
                    Personagem.UsarHabilidade();
                }
            }
        }
    }
}
