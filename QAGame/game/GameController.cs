using QAGame.data;
using System;
using System.Linq;
using System.Threading;

namespace QAGame.game
{
    public class GameController
    {
        private readonly State _state;
        private readonly QuestionBase _questionBase;

        private int questionIndex = 0;
        private int correctAnswers = 0;
        private int wrongAnswers = 0;
        public GameController(State state, QuestionBase questionBase)
        {
            _state = state;
            _questionBase = questionBase;
            questionIndex = 0;

            CustomClear();
        }
        public void CustomClear()
        {
            Console.Clear();
            this.GameHeader();
            this.GameBody();
            this.GameFooter();
        }

        private void ResetStats()
        {
            questionIndex = 0;
            wrongAnswers = 0;
            correctAnswers = 0;
        }

        public void GameHeader()
        {

            Console.WriteLine(string.Format("-- Level: {0} C: {1} W:{2} --", _state.LevelIndex.ToString(),correctAnswers.ToString(), wrongAnswers.ToString()));

        }

        public void GameBody()
        {
            int lenghtQuestionBase = 0;
            if (_questionBase.levels.FirstOrDefault(x => x.Id == _state.LevelIndex.ToString()) == null)
            {
                Console.WriteLine("You have beaten the game!");
                Console.WriteLine("Press any key to exit!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
               lenghtQuestionBase = _questionBase.levels.FirstOrDefault(x => x.Id == _state.LevelIndex.ToString()).Lenght;
            }


            if (questionIndex >= lenghtQuestionBase)
            {
                if (correctAnswers > wrongAnswers)
                {
                    Console.WriteLine("You have passed the level");
                    _state.LevelIndex += 1;
                    ResetStats();

                    CustomClear();
                }
                else
                {
                    Console.WriteLine("You have failed the level");
                    ResetStats();

                    CustomClear();
                }
            }
            else
            {
                if (Helpers.AskQuestion(_state.LevelIndex.ToString(), questionIndex.ToString(), _questionBase) == true)
                {
                    Console.WriteLine("You Got It Right!!");
                    Thread.Sleep(1000);
                    _state.CorrectAnswers += 1;
                    correctAnswers += 1;
                    questionIndex += 1;

                    CustomClear();
                }
                else
                {
                    Console.WriteLine("You Got It Wrong :(");
                    Thread.Sleep(1000);
                    _state.WrongAnswers += 1;
                    wrongAnswers += 1;
                    questionIndex += 1;

                    CustomClear();
                }

            }
        }
        public void GameFooter()
        {

        }

    }
}
