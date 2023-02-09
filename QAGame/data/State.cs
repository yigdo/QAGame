using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAGame.data
{
    public class State
    {
        public int CorrectAnswers { get; set; } = 0;
        public int WrongAnswers { get; set; } = 0;
        public int LevelIndex { get; set; } = 0;
    }
}
