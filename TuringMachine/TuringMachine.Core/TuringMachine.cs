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

        public void DoAlgorithm()
        {
            while(CurrentState.GetState() != EndState.GetState())
            {
                foreach(var rule in Rules)
                {
                    if (rule.CurrentState.GetState() == CurrentState.GetState())
                    {
                        this.ExecuteRule(rule);

                        this.PrintRibbons();


                    }
                }
            }
        }

        public void PrintRibbons()
        {
            int ribbonNumber = 1;

            foreach (var ribbon in this.Ribbons)
            {
                Console.WriteLine(ribbonNumber + " лента:");

                Console.WriteLine(ribbon.ToString());
            }

            Console.WriteLine();
        }
        
    }
}
