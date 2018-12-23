using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QuizMaker.Classes
{
    public class Question
    {
        private string question;
        private List<string> answers;
        public Question(List<string> line)
        {
            question = line[0];
            line.Remove(line[0]);
            answers = line;
        }
        public string Prompt
        {
            get
            {
                return question;
            }
        }
        public List<string> Answers
        {
            get
            {
                return answers;
            }
        }
    }
}


