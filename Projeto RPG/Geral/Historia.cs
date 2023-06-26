using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Geral
{
    internal class Historia
    {
        public Historia () { }

        public void HisIntroducao(Personagem player)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Bem vindo à LEGENDS OF MUSTAFHAR");
            Console.WriteLine("\nHumanos e todos os outros seres viviam em harmonia, até que Cairo, o líder da maior vila humana decidiu aprisionar o poderoso rei dos dragões: Mustafhar.");
            Console.WriteLine("Furioso, a fera matou Cairo e destruiu sua vila. A humanidade se dividiu pelo mundo e passou a ser odiada pelo Clã dos Orcs e a Ordem dos Elfos.");
            Console.WriteLine("Todos os dragões, sob o comando de Mustafhar, caçam os humanos pelo mundo.");
            Console.WriteLine($"Bem vindo {player.Nome}. A humanidade precisa de um novo líder. Alguém que enfrente todos em seu caminho, derrote Mustafhar, e unifique novamente nosso povo.");
            Console.WriteLine($"\nVOCÊ ESTÁ PREPARADO {player.Nome.ToUpper()}???");
            string op = (Console.ReadLine()).ToLower();
            if (op.StartsWith("n"))
            {
                Console.Clear();
                Console.WriteLine("Obrigado por NÃO jogar!!");
                Creditos();
                Environment.Exit(0);
            }
        }

        public void HisFinal(Personagem player)
        {
            Console.Clear();
            Console.WriteLine($"Após o último golpe, o rei dos dragões cai morto em sua caverna e {player.Nome} permanece de pé.");
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"\nApós décadas de caos, a humanidade se une novamente. {player.Nome} é coroado rei, e institui uma trégua entre os humanos, os elfos e os orcs.");
            Console.WriteLine("Os dragões, os golens e outras criaturas do mundo se estabelecem em locais remotos. O rei proíbe todo e qualquer ataque à elas, estabelecendo um período de paz em todo o mundo.");
            Console.WriteLine($"Parabéns {player.Nome}!!! Você zerou o jogo.");
            Console.ReadKey();
            Console.Clear();
        }

        public void Creditos()
        {
           
            Console.WriteLine("\n\n=========================================================================================================");
            Console.WriteLine("\n                                              CRÉDITOS");
            Console.WriteLine("\n\n");
            Console.WriteLine("                                          Bernardo Chiamolera");
            Console.WriteLine("                                             Gabriel Labes");
            Console.WriteLine("                                             Lucas Belletti");
            Console.WriteLine("                                              Nadia Naely");
            Console.WriteLine("                                           Vinicius Grossert");
            Console.WriteLine("\n===========================================================================================================");
            Console.ReadKey();
        }

        public void PosCreditos(Personagem player)
        {
            Console.Clear();
            Console.WriteLine("[Na caverna de Mustafhar]\n...");
            Console.ReadKey();
            Console.WriteLine("... *rugidos de dor* ...");
            Console.ReadKey();
            Console.WriteLine($"Mustafhar: -QUEIMAREI TUDO QUE {(player.Nome).ToUpper()} AMA!!!");
            Console.WriteLine("...");
            Console.ReadKey();

        }






    }
}
