using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        // Variáveis
        private float highScore;
        private int playedGames;
        private int wonGames;

        // Propriedade c/ variável de suporte
        // Se o novo score for superior ao score existente, alterar a variável de suporte
        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                    highScore = value;
            }
        }

        // Propriedade auto-implementada
        public string Name { get; }

        // Propriedade só de leitura que devolve a percentagem de jogos ganhos 
        // (entre 0 a 1)
        public float WinRate => playedGames == 0 ? 0f : (float)wonGames / playedGames;

        // Construtor
        public Player(string name)
        {
            Name = name;
            this.highScore = 0;
            this.playedGames = 0;
            this.wonGames = 0;
        }

        // Método que atualiza os dados dos jogadores
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
            {
                wonGames++;
            }
        }
    }
}