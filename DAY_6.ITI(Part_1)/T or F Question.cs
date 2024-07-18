using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_6.ITI_Part_1_
{
    internal class TorFQuestion :Question
    {
        public TorFQuestion( string body, int mark) : base( body, mark)
        {
        }
        public override string ToString()
        {
            return $"{base.ToString()}\nAnswer: True or False";
        }

        public override bool Equals(object obj)
        {
            return obj is TorFQuestion && base.Equals(obj);
        }

    }
}
