using QAGame.data;
using QAGame.models;
using System;
using System.Linq;

namespace QAGame.game
{
    public static class Helpers
    {
        public static void ClearConsole()
        {
            Console.Clear();

            Console.WriteLine("-- QA GAME -- \n\n");
        }
        public static bool AskQuestion(string surveyId, string questionId, QuestionBase _questionBase)
        {

            Question question = _questionBase.levels.FirstOrDefault(x => x.Id == surveyId).Questions.FirstOrDefault(x => x.QuestionId == questionId);

            if (question == null)
            {
                return false;
            }

            Console.WriteLine(string.Format("-- [?]: Question: {0} --", question.QuestionTitle));
            foreach (Answer answer in question.QuestionAnswers)
            {
                Console.WriteLine(string.Format("[{0}]: {1}", new string[] { answer.Index.ToString(), answer.Title }));
            }
            Console.Write("[?]: Answer?");
            string givenAnswer = Console.ReadLine();
            int answerIndex = 4;
            try
            {
                answerIndex = int.Parse(givenAnswer);
            }
            catch { Console.WriteLine("Please enter index of the question!"); }

            if(answerIndex == question.CorrectAnswer)
            {
                return true;
            }else return false;
        }
    }
}
