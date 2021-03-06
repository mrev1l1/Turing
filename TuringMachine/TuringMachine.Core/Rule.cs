﻿using System;
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

        public override string ToString()
        {
            String Result = 'q' + this.CurrentState.StateNumber.ToString() + 
                '('+ new String(CurrentSymbols.ToArray()) + ")-q"+this.NextState.StateNumber.ToString()+'('+new String(NextSymbols.ToArray())+ ')' + '(' +new String(Shifts.ToArray())+')';
            return Result;
        }

        public static void StringToRule(Rule rule)
        {

        }
    }
}
