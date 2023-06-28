using Projeto_RPG.Personagens.Habilidades;
using Projeto_RPG.Personagens.Inimigo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Projeto_RPG.Personagens.Classes
{
    internal class Mago : Personagem
    {        
        public int PontosMagiaMax { get; set; }
        public int PontosMagiaAtual { get; set; }
        public List<Magia> Magias { get; set; }

        public Mago(string nome) : base(nome)
        {
            Nome = nome;
            Classe = "Mago";
            PontosVidaMax = 80;
            PontosVidaAtual = PontosVidaMax;
            Forca = 5;
            Defesa = 5;
            PontosMagiaMax = 110;
            PontosMagiaAtual = PontosMagiaMax;
            Magias = new List<Magia>();
        }

        public override void Atacar(Personagem inimigo)
        {
            base.Atacar(inimigo);
        }

        public override void UsarHabilidade(Personagem inimigo)
        {
            base.UsarHabilidade(inimigo);
        }

        public void UsarMagia(Personagem alvo, Magia magia)
        {
            if(magia.Custo > PontosMagiaAtual)
            {
                Console.WriteLine("Você não tem mana suficiente.");
                
            }
            else
            {
                if(magia.Nome == "Magia de cura")
                {
                    Console.WriteLine($"Você se cura {magia.Dano} pontos de vida");
                    if (PontosVidaAtual + magia.Dano > PontosVidaMax) PontosVidaAtual = PontosVidaMax;
                    PontosVidaAtual += magia.Dano;
                    PontosMagiaAtual -= magia.Custo;
                    
                }
                else
                {
                    Inimigo.Inimigo inimigo = (Inimigo.Inimigo)alvo;
                    if(inimigo.Tipo == magia.Fraqueza)
                    {
                        Console.WriteLine($"Você usa {magia.Nome}");
                        inimigo.PontosVidaAtual -= magia.Dano * 2;
                    }
                    else
                    {
                        Console.WriteLine($"Você usa {magia.Nome}");
                        inimigo.PontosVidaAtual -= magia.Dano;
                    }
                    alvo.EfeitoSofrido = magia.Efeito;
                    PontosMagiaAtual -= magia.Custo;
                }
            }
        }

        public override void Defender()
        {
            base.Defender();
        }

        public override void Fugir(Personagem Fugitivo)
        {
            base.Fugir(Fugitivo);
        }

        public override void SubirNivel() 
        {
            if (ExpAtual >= 5 && ExpAtual < 35 && Nivel != 2)
            {
                Nivel = 2;
                PontosVidaMax += 5;
                Forca += 10;
                Defesa += 15;
                PontosMagiaMax += 30;


                Console.WriteLine($"{Nome} subiu para o nível {Nivel} e recuperou toda a vida e mana");
                PontosVidaAtual = PontosVidaMax;
                PontosMagiaAtual = PontosMagiaMax;
            }
            if (ExpAtual >= 35 && ExpAtual < 50 && Nivel != 3)
            {
                Nivel = 3;
                PontosVidaMax += 10;
                Forca += 15;
                Defesa += 20;
                PontosMagiaMax += 25;

                Console.WriteLine($"{Nome} subiu para o nível {Nivel} e recuperou toda a vida e mana");
                PontosVidaAtual = PontosVidaMax;
                PontosMagiaAtual= PontosMagiaMax;
            }
            if (ExpAtual >= 50)
            {
                Nivel = 4;
                PontosVidaMax += 30;
                Forca += 7;
                Defesa += 15;

                PontosMagiaMax += 20;

                Console.WriteLine($"{Nome} subiu para o nível {Nivel} e recuperou toda a vida e mana");
                PontosVidaAtual = PontosVidaMax;
                PontosMagiaAtual = PontosMagiaMax;
             }
        }

        public override void Status()
        {
            Console.WriteLine("========================");
            Console.WriteLine($" Nome: {Nome}. Mago nível {Nivel}");
            Console.Write(" Vida: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{PontosVidaAtual}/{PontosVidaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" Mana: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{ PontosMagiaAtual}/{ PontosMagiaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" Força: {Forca}");
            Console.WriteLine("========================");
            Console.Write("\nPressione qualquer tecla para continuar");
            Console.ReadKey();

        }
    }
}
