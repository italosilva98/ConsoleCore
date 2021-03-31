using System;
using GameTOP.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFODA(
                new Jogador2(), 
                new Jogador1());
            jogo.IniciarJogo();
        }
    }

}

// atalhos: ctor
