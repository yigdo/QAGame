using QAGame.data;
using QAGame.game;
using System;

namespace QAGame
{
    public class Program
    {
        public static State _gameState = new State();
        public static QuestionBase _questionBase = new QuestionBase();
        static void Main(string[] args)
        {

            QAGameEntry game = new QAGameEntry(_gameState, _questionBase);

            Console.ReadKey();
        }
    }
}
