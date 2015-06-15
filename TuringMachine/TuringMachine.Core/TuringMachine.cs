using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Core
{
    public class TuringMachine : IMachine
    {
        public TuringMachine()
        {

        }

        public TuringMachine(int ribbonNumber)
        {
            Ribbons = new List<Ribbon>(ribbonNumber);
        }

        public bool ExecuteRule(Rule rule)
        {
            bool isRuleBroken = false;

            for (int i = 0; i < this.Ribbons.Count; i++)
            {
                int index = Ribbons[i].CurrentPosition;

                if (rule.CurrentSymbols[i].Equals(Ribbons[i].RibbonString[index]))
                {
                    continue;
                }
                else
                {
                    isRuleBroken = true;

                    break;
                }
            }

            if (!isRuleBroken)
            {
                for (int i = 0; i < this.Ribbons.Count; i++)
                {
                    int index = Ribbons[i].CurrentPosition;

                    this.Ribbons[i].RibbonString[index] = rule.NextSymbols[i];

                    switch (rule.Shifts[i])
                    {
                        case 'R': this.Ribbons[i].CurrentPosition++; break;
                        case 'L': this.Ribbons[i].CurrentPosition--; break;
                        case 'E': break;
                    }
                }

                this.CurrentState = rule.NextState;

                return true;    
            }
            else
            {
                return false;
            }
        }

        public List<Ribbon> Ribbons
        {
            get;

            set;
        }

        public List<Rule> Rules
        {
            get;

            set;
        }

        public State CurrentState
        {
            get;

            set;
        }

        public State EndState
        {
            get;

            set;
        }

        public KeyValuePair<List<String>, int> DoAlgorithm()
        {
            List<String> Log = new List<string>();
            Int32 StepCount = 0;
            KeyValuePair<List<String>, int> Result;

            while(true)
            {
                foreach(var rule in Rules)
                {
                    if (CurrentState.StateNumber != EndState.StateNumber)
                    {
                        if (rule.CurrentState.StateNumber == CurrentState.StateNumber)
                        {
                            if (this.ExecuteRule(rule))
                            {
                                Log.AddRange(this.PrintRibbons());
                                StepCount++;
                            }
                        }
                    }
                    else
                    {
                        Result = new KeyValuePair<List<String>, int>(Log, StepCount);
                        return Result;
                    }
                }
            }
        }

        public List<String> PrintRibbons()
        {
            List<String> RibbonState = new List<string>();
            
            int ribbonNumber = 1;

            foreach (var ribbon in this.Ribbons)
            {
                RibbonState.Add(ribbonNumber + " лента:");

                RibbonState.Add(ribbon.ToString());

                ribbonNumber++;
            }
            RibbonState.Add("");
            return RibbonState;
        }
    }
}
