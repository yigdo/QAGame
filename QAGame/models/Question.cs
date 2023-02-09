using System.Collections.Generic;

namespace QAGame.models
{
    public class Question
    {
        public string QuestionId { get; set; }
        public string QuestionTitle { get; set; }
        public int CorrectAnswer { get; set; }

        public List<Answer> QuestionAnswers { get; set; }
    }
}
