using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6.ITI_Part_1_
{
    internal abstract class Question
    {
        protected static int currentNum = 1;
        protected int num;
        protected string body;
        protected int mark;

        public Question(string body, int mark)
        {
            this.num = currentNum++;
            this.body = body;
            this.mark = mark;
        }

        public override string ToString()
        {
            return $"Question Number: {num}\nQuestion Body: {body}\nMarks: {mark}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Question)
            {
                Question other = (Question)obj;
                return num == other.num && body == other.body && mark == other.mark;
            }
            return false;
        }


    }
}
