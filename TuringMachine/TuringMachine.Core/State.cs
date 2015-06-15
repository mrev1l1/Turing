using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Turing.Core
{
    [Serializable]
    public class State
    {
        public State()
        {
        
        }

        public State(int number)
        {
            this.StateNumber = number;
        }

        [DataMember]
        public int StateNumber { get; set; }
    }
}
