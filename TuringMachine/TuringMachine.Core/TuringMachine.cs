using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Core
{
    public class TuringMachine
    {
        public TuringMachine()
        {

        }

        public TuringMachine(int ribbonNumber)
        {
            Ribbons = new List<Ribbon>(ribbonNumber);
        }

        public void ExecuteRuleT(Rule rule)
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
                }
            }

            if (!isRuleBroken)
            {
                for (int i = 0; i < this.Ribbons.Count; i++)
                {
                    int index = Ribbons[i].CurrentPosition;

                    Ribbons[i].RibbonString[index] = rule.NextSymbols[i];

                    switch (rule.Shifts[i])
                    {
                        case 'R': Ribbons[i].CurrentPosition++; break;
                        case 'L': Ribbons[i].CurrentPosition--; break;
                        case 'E': break;
                    }
                }

                this.CurrentState = rule.NextState;
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

        public void DoAlgorithm()
        {
            //foreach (var rule in Rules)
            //{
            //    this.ExecuteRule(rule);
            //}
            while(CurrentState.GetState()!=EndState.GetState())
            {
                foreach(var rule in Rules)
                {
                    if (rule.CurrentState.GetState() == CurrentState.GetState())
                        this.ExecuteRuleT(rule);
                }
            }

            this.ToString();

        }

        
    }
}
