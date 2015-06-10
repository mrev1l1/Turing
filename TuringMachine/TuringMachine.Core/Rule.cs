using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Turing.Core
{    
    [Serializable]
    public class Rule
    {
        public Rule()
        {

        }

        [XmlArray(ElementName = "CurrentSymbols")]
        public List<char> CurrentSymbols
        {
            get;

            set;
        }

        [XmlArray(ElementName = "NewSymbols")]
        public List<char> NextSymbols
        {
            get;

            set;
        }

        [XmlArray(ElementName = "PositionShifts")]
        public List<char> Shifts
        {
            get;

            set;
        }

        [XmlAttribute]
        public State CurrentState
        {
            get;

            set;
        }
        
        [XmlAttribute]
        public State NextState
        {
            get;

            set;
        }
    }
}
