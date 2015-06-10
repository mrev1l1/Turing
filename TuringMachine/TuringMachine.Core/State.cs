using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Turing.Core
{
    public class State
    {
        private int StateNumber;

        public State()
        {
        
        }

        public State(int number)
        {
            this.StateNumber = number;
        }

        public int GetState()
        {
            return StateNumber;
        }
    }
}
