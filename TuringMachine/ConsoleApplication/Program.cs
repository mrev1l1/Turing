using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Core;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TuringMachine turing = new TuringMachine(3);

            List<Rule> tmrules = new List<Rule>();

            for (int i = 0; i < 6; i++) tmrules.Add(new Rule());

                tmrules[0].CurrentState = new State(0);
            tmrules[0].CurrentSymbols = new List<char> { '1', 'l', 'l' };
            tmrules[0].NextState = new State(0);
            tmrules[0].NextSymbols = new List<char> { '1', '1', 'l' };
            tmrules[0].Shifts = new List<char> { 'R', 'R', 'E' };

            tmrules[1].CurrentState = new State(0);
            tmrules[1].CurrentSymbols = new List<char> { '>', 'l', 'l' };
            tmrules[1].NextState = new State(1);
            tmrules[1].NextSymbols = new List<char> { '>', 'l', 'l' };
            tmrules[1].Shifts = new List<char> { 'R', 'L', 'E' };

            tmrules[2].CurrentState = new State(1);
            tmrules[2].CurrentSymbols = new List<char> { '1', '1', 'l' };
            tmrules[2].NextState = new State(1);
            tmrules[2].NextSymbols = new List<char> { '1', 'l', 'l' };
            tmrules[2].Shifts = new List<char> { 'R', 'L', 'E' };

            tmrules[3].CurrentState = new State(1);
            tmrules[3].CurrentSymbols = new List<char> { 'l', '1', 'l' };
            tmrules[3].NextState = new State(2);
            tmrules[3].NextSymbols = new List<char> { 'l', '1', '1' };
            tmrules[3].Shifts = new List<char> { 'R', 'L', 'E' };

            tmrules[4].CurrentState = new State(1);
            tmrules[4].CurrentSymbols = new List<char> { 'l', 'l', 'l' };
            tmrules[4].NextState = new State(2);
            tmrules[4].NextSymbols = new List<char> { 'l', 'l', '0' };
            tmrules[4].Shifts = new List<char> { 'R', 'L', 'E' };

            tmrules[5].CurrentState = new State(1);
            tmrules[5].CurrentSymbols = new List<char> { '1', 'l', 'l' };
            tmrules[5].NextState = new State(2);
            tmrules[5].NextSymbols = new List<char> { '1', 'l', '0' };
            tmrules[5].Shifts = new List<char> { 'R', 'L', 'E' };

            turing.Rules = tmrules;

            turing.CurrentState = new State(0);
            turing.EndState = new State(2);

            List<Ribbon> Ribbons = new List<Ribbon>();
            Ribbons.Add(new Ribbon(new List<char> { 'l', '1', '>', '1', '1', 'l' }));
            Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));
            Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));

            Ribbons[0].CurrentPosition = 1;
            Ribbons[1].CurrentPosition = 1;
            Ribbons[2].CurrentPosition = 1;


            turing.Ribbons = Ribbons;
            turing.DoAlgorithm();

            //string[] ribbs = new string[3];

            //ribbs[0] = "000000000000000000000000000000000";

            //ribbs[1] = "000000000000000000001111111100000";

            //ribbs[2] = "000000000000020000002022222200000";

            //for (int i = 0; i < ribbs.Length; i++)
            //{
            //    turing.Ribbons.Add(new Ribbon(ribbs[i]));
            //}

            //Rule rule = new Rule();

            //rule.CurrentSymbols = new List<char>();

            //rule.CurrentSymbols.AddRange();

            //turing.Rules = new List<Rule>();

            //turing.Rules.Add(new Rule());
        }
    }
}
