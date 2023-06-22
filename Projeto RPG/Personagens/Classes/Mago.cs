using Projeto_RPG.Personagens.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            PontosVidaMax = 100;
            PontosVidaAtual = PontosVidaMax;
            Forca = 30;
            Defesa = 30;
            PontosMagiaMax = 100;
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

        public void UsarMagia() { }

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
            base.SubirNivel();
        }

        public override void Status()
        {
            Console.WriteLine("========================");
            Console.WriteLine($" Nome: {Nome}. Mago nível {Nivel}");
            Console.WriteLine(" Vida: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{PontosVidaAtual}/{PontosVidaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($" Mana: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{ PontosMagiaAtual}/{ PontosMagiaMax}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($" Força: {Forca}");
            Console.WriteLine("========================");
            Console.ReadKey();

        }
    }
}
