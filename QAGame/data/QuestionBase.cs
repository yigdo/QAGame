using QAGame.models;
using System.Collections.Generic;

namespace QAGame.data
{
    public class QuestionBase
    {
        public List<Level> levels = new List<Level>()
        {
            new Level()
            {
                Id = "0",
                Name = "Tutorial Level",
                Lenght = 2,
                Questions = new List<Question>()
                {
                    new Question()
                    {
                        QuestionId = "0",
                        QuestionTitle = "Test Question",
                        CorrectAnswer = 0,
                        QuestionAnswers = new List<Answer>()
                        {
                            new Answer()
                            {
                                Index = 0,
                                Title = "True",
                                Selected = false,
                            },
                            new Answer()
                            {
                                Index = 1,
                                Title = "False",
                                Selected = false,
                            },
                              new Answer()
                            {
                                Index = 2,
                                Title = "All of the above",
                                Selected = false,
                            },
                        }
                    },
                    new Question()
                    {
                        QuestionId = "1",
                        QuestionTitle = "Do you love this game?",
                        CorrectAnswer = 2,
                        QuestionAnswers = new List<Answer>()
                        {
                            new Answer()
                            {
                                Index = 0,
                                Selected = false,
                                Title = "No"
                            },
                            new Answer()
                            {
                                Index = 1,
                                Selected = false,
                                Title = "I hate it"
                            },
                            new Answer()
                            {
                                Index = 2,
                                Selected = false,
                                Title = "lowkey I love it!"
                            },

                        }
                    }
                }
            },
            new Level()
            {
                Id = "1",
                Name = "Lvel 1: Minecraft Trivia",
                Lenght = 1,
                Questions = new List<Question>()
                {
                    new Question()
                    {
                        QuestionId = "0",
                        QuestionTitle = "How many diamonds it takes to craft a hoe?",
                        CorrectAnswer = 1,
                        QuestionAnswers = new List<Answer>()
                        {
                            new Answer()
                            {
                                Index = 0,
                                Title = "1",
                                Selected = false,
                            },
                            new Answer()
                            {
                                Index = 1,
                                Title = "2",
                                Selected = false,
                            },
                              new Answer()
                            {
                                Index = 2,
                                Title = "4",
                                Selected = false,
                            },
                        }
                    }
                }
            }
        };
    }
}
