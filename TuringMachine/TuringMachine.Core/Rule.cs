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
    public class Rule
    {
        public Rule()
        {

        }

        [DataMember]
        public List<char> CurrentSymbols
        {
            get;

            set;
        }

        [DataMember]
        public List<char> NextSymbols
        {
            get;

            set;
        }

        [DataMember]
        public List<char> Shifts
        {
            get;

            set;
        }

        [DataMember]
        public State CurrentState
        {
            get;

            set;
        }
        
        [DataMember]
        public State NextState
        {
            get;

            set;
        }
    }
}
