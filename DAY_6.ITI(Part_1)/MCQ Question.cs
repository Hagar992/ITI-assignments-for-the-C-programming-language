using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6.ITI_Part_1_
{
    internal class MCQ_Question:Question
    {
        private string[] answer;

        public MCQ_Question(string body, int mark, string[] answer)
             : base(body, mark)
        {
            this.answer = answer;
        }
       
        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Answers:");

            foreach (string answers in answer)
            {
                sb.AppendLine($"- {answers}");
            }

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is MCQ_Question)
            {
                MCQ_Question other = (MCQ_Question)obj;
                return base.Equals(other) && answer.Length == other.answer.Length && Equals(answer, other.answer);
            }
            return false;
        }

    }
}
