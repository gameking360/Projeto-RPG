using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_RPG.Geral
{
    internal class Tutorial
    {
        public Tutorial () { }

        public void TutorialMenu()
        {
            bool f = true;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("        TUTORIAIS");
                Console.WriteLine("=========================");
                Console.WriteLine("| (1) Como jogar        |");
                Console.WriteLine("| (2) Classes           |");
                Console.WriteLine("| (3) Elementos/Efeitos |");
                Console.WriteLine("| (4) Inimigos          |");
                Console.WriteLine("| (5) Voltar            |");
                Console.WriteLine("=========================");
                switch (Console.ReadLine())
                {
                    case "1": TutorialComoJogar();
                        break;
                    case "2": TutorialClasses();
                        break;
                    case "3": TutorialEfeitos();
                        break;
                    case "4": TutorialInimigos();
                        break;
                    case "5": f = false;
                        break;
                    default: Console.Clear();
                             Console.WriteLine("Opção inválida! (Aperte qualquer tecla para continuar)");
                             Console.ReadKey();
                        break;
                }
            }
        }

        public void TutorialComoJogar()
        {
            Console.Clear();
            Console.WriteLine("============================================================================================================");
            Console.WriteLine("Em Legends of Mustafhar, tudo que você precisa para jogar é seguir os indicadores de cada momento");
            Console.WriteLine("pressionando o número da ação que você deseja realizar");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Ações Básicas:");
            Console.WriteLine("\nAtacar: Seu personagem causará um dano levemente variável, de acordo com seu atributo força.");
            Console.WriteLine("Defender: Seu personagem bloqueará parcial ou totalmente o dano inimigo, de acordo com sua defesa.");
            Console.WriteLine("Usar habilidade: Você poderá usar uma das habilidades ou magia (para o mago). Vide tutorial das classes.");
            Console.WriteLine("Fugir: Seu personagem tentará fugir da batalha, podendo falhar, conseguir parcialmente ou sem nenhum arranhão.");
            Console.WriteLine("===========================================================================================================");
            Console.Write("\nPressione qualquer tecla para voltar:");
            Console.ReadKey();
        }
        public void TutorialClasses()
        {
            Console.Clear();
            Console.WriteLine("===============================================================================================================");
            Console.WriteLine("Existem três classes disponíveis para o seu personagem: Guerreiro, Arqueiro e Mago.");
            Console.WriteLine("Cada uma com atributos e habilidades diferentes.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nGuerreiro: É a classe com mais vida e força. Tem as habilidades de ...");
            Console.WriteLine("\nArqueiro: Possui a destreza, que aumenta suas chances de desviar dos golpes inimigos e causar dano crítico");
            Console.WriteLine("Suas habilidades são flechas especiais que causam efeitos variados");
            Console.WriteLine("\nMago: Tem atributos base mais fracos, porém é capaz de conjurar poderosas magias para causar dano, efeitos e cura.");
            Console.WriteLine("========================================================================================================================");
            Console.Write("\nPressione qualquer tecla para voltar:");
            Console.ReadKey();
        }
        public void TutorialEfeitos()
        {
            Console.Clear();
            Console.WriteLine("=======================================================================================================================================");
            Console.WriteLine("As habilidades e os inimigos tem seus elementos, causando diferentes efeitos com fraquezas e resistências.\nHá 5 elementos conhecidos no mundo de Legends of Mustafhar.");
            Console.WriteLine("São eles: Fogo, Gelo, Eletricidade, Grama e Água.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nFogo: Causa o efeito 'queimado' onde o personagem atingido queima por 2 rodadas. O rei dos dragões Mustafhar é desse elemento.");
            Console.WriteLine("Gelo: Causa o efeito 'congelado' onde o personagem atingido fica 1 rodada sem agir");
            Console.WriteLine("Grama: Causa o efeito 'envenenado' onde o personagem atingido sofre dano a cada rodada. E há também a magia de grama do mago, que o cura.");
            Console.WriteLine("Água: Causa o efeito de fraqueza onde o personagem atingido sofre mais dano em cada golpe");
            Console.WriteLine("Eletricidade: É o elemento mais poderoso e destrutivo que há. Aquele capaz de controlá-lo é capaz de derrotar qualquer inimigo.");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Propriedades não-elementais:");
            Console.WriteLine("\nCortante: Lâminas afiadíssimas provocam o efeito de sangramento que causa dano no oponente por duas rodadas");
            Console.WriteLine("Perfurante: Pontas de flechas sofisticadas perfuram qualquer coisa causando fraqueza no inimigo, que o deixa mais vulnerável à ataques.");
            Console.WriteLine("========================================================================================================================================");
            Console.Write("\nPressione qualquer tecla para voltar:");
            Console.ReadKey();


        }
        public void TutorialInimigos()
        {
            Console.Clear();
            Console.WriteLine("======================================================================================================================================================");
            Console.WriteLine("                   No vasto mundo de Legends of Mustafhar existem criaturas épicas e perigosas.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("\nOs Elfos são uma raça de seres pequenos porém muito engenhosos e destemidos. Não são um problema para um aventureiro corajoso.");
            Console.WriteLine("\nOs Orcs são uma espécie grande e forte, porém desengonçada e descontrolada. Duros de derrubar sendo necessário certa inteligência do aventureiro.");
            Console.WriteLine("\nAs Ents são árvores vivas bizarras, rejeitadas por todas as outras criaturas. Não muito agressivas, mas capazes de criar armadilhas aos viajantes.");
            Console.WriteLine("\nOs Golens são grandes amontoados de rochas vivos. Extremamente lentos porém com uma força inigualável. Podem esmagar um aventureiro em um só golpe.");
            Console.WriteLine("\nOs Dragões são feras comuns ao redor do mundo. Até mesmo os bebês podem matar um descuidado. E os adultos são um grande perigo para qualquer um.");
            Console.WriteLine("======================================================================================================================================================");
            Console.Write("\nPressione qualquer tecla para voltar:");
            Console.ReadKey();
        }
    }
}
