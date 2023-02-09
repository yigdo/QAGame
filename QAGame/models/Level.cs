using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAGame.models
{
    public class Level
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Lenght { get; set; }

        public List<Question> Questions { get; set; }
    }
}
