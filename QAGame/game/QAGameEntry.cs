using QAGame.data;
using System;
using System.Threading;

namespace QAGame.game
{
    public class QAGameEntry
    {
        private QuestionBase _questionBase;
        private State _state;

        public QAGameEntry(State state,
                           QuestionBase questionBase)
        {
            _state = state;
            _questionBase = questionBase;

            this.Render();
        }

        public void Render()
        {
            this.MainMenu();
        }

        public void MainMenu()
        {
            Helpers.ClearConsole();

            Console.WriteLine("-- Welcome to QArPg --");

            Console.WriteLine("[1]: Start Game" +
                "\n[2]: Credits" +
                "\n[3]: Exit");
            Console.Write("[?]: ");
            try
            {
                int selection = int.Parse(Console.ReadLine());

                switch (selection)
                {
                    case 1:
                        this.GameStart();
                        break;
                    case 2:
                        this.Credits();
                        break;
                    case 3:
                    default:
                        System.Environment.Exit(0);
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Please enter in the correct format.");
                Thread.Sleep(2000);
                this.MainMenu();
            }
        }

        public void Credits()
        {
            Helpers.ClearConsole();

            Console.WriteLine("Design & Coding: Yiğit Gülay");
            Console.WriteLine("Idea & Development: NIY");

            Console.ReadKey();
            this.MainMenu();
        }

        public void GameStart()
        {

            GameController gameController = new GameController(_state,
                                                               _questionBase);

        }
    }
}
