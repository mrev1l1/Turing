using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Core;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TuringMachine turing = new TuringMachine();

            InitializeTuringMachine(turing);

            //List<Rule> tmrules = new List<Rule>();

            //for (int i = 0; i < 6; i++) tmrules.Add(new Rule());

            //tmrules[0].CurrentState = new State(0);
            //tmrules[0].CurrentSymbols = new List<char> { '1', 'l', 'l' };
            //tmrules[0].NextState = new State(0);
            //tmrules[0].NextSymbols = new List<char> { '1', '1', 'l' };
            //tmrules[0].Shifts = new List<char> { 'R', 'R', 'E' };

            //string s = JsonHelper.JsonSerializer<Rule>(tmrules[0]);

            //Console.WriteLine(s);

            //tmrules[1].CurrentState = new State(0);
            //tmrules[1].CurrentSymbols = new List<char> { '>', 'l', 'l' };
            //tmrules[1].NextState = new State(1);
            //tmrules[1].NextSymbols = new List<char> { '>', 'l', 'l' };
            //tmrules[1].Shifts = new List<char> { 'R', 'L', 'E' };

            //tmrules[2].CurrentState = new State(1);
            //tmrules[2].CurrentSymbols = new List<char> { '1', '1', 'l' };
            //tmrules[2].NextState = new State(1);
            //tmrules[2].NextSymbols = new List<char> { '1', 'l', 'l' };
            //tmrules[2].Shifts = new List<char> { 'R', 'L', 'E' };

            //tmrules[3].CurrentState = new State(1);
            //tmrules[3].CurrentSymbols = new List<char> { 'l', '1', 'l' };
            //tmrules[3].NextState = new State(2);
            //tmrules[3].NextSymbols = new List<char> { 'l', '1', '1' };
            //tmrules[3].Shifts = new List<char> { 'R', 'L', 'E' };

            //tmrules[4].CurrentState = new State(1);
            //tmrules[4].CurrentSymbols = new List<char> { 'l', 'l', 'l' };
            //tmrules[4].NextState = new State(2);
            //tmrules[4].NextSymbols = new List<char> { 'l', 'l', '0' };
            //tmrules[4].Shifts = new List<char> { 'R', 'L', 'E' };

            //tmrules[5].CurrentState = new State(1);
            //tmrules[5].CurrentSymbols = new List<char> { '1', 'l', 'l' };
            //tmrules[5].NextState = new State(2);
            //tmrules[5].NextSymbols = new List<char> { '1', 'l', '0' };
            //tmrules[5].Shifts = new List<char> { 'R', 'L', 'E' };

            //turing.Rules = tmrules;

            //turing.CurrentState = new State(0);
            //turing.EndState = new State(2);

            //List<Ribbon> Ribbons = new List<Ribbon>();
            //Ribbons.Add(new Ribbon(new List<char> { 'l', '1', '>', '1', '1', 'l' }));
            //Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));
            //Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));

            //Ribbons[0].CurrentPosition = 1;
            //Ribbons[1].CurrentPosition = 1;
            //Ribbons[2].CurrentPosition = 1;

            //String JsonRule = JsonHelper.JsonSerializer<Rule>(tmrules[0]);

            //turing.Ribbons = Ribbons;
            //turing.DoAlgorithm();

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

        static void InitializeTuringMachine(TuringMachine value)
        {
            Console.WriteLine("Введите количество лент:");
            
            value = new TuringMachine(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Введите количество команд:");

            int RuleQuantity = Convert.ToInt32(Console.ReadLine());

            List<Rule> tmrules = new List<Rule>();

            Console.WriteLine("Задайте команды для алгоритма Машины Тьюринга:");
            for (int i = 0; i < RuleQuantity; i++)
            {
                tmrules.Add(new Rule());

                Console.WriteLine("Введите номер состояния для " + (i+1).ToString() + "команды:");

                tmrules[i].CurrentState = new State(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Введите символы, встречающиеся на лентах:");

                String Symbols = Console.ReadLine();
                
                tmrules[i].CurrentSymbols = Symbols.ToList<char>();

                Console.WriteLine("Введите номер состояния, в которое данная команда переводит Машину:");

                tmrules[i].NextState = new State(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Введите символы, на которые заменяются входящие символы на лентах:");

                String NewSymbols = Console.ReadLine();

                tmrules[i].NextSymbols = NewSymbols.ToList<char>();

                Console.WriteLine("Укажите смещения УУ для лент:");

                String Shifts = Console.ReadLine();

                tmrules[i].Shifts = Shifts.ToList<char>();

                Console.WriteLine("Введенная команда:");
                Console.WriteLine(tmrules[i].ToString());
                Console.WriteLine("Все правильно? Y|N");

                String Choice = Console.ReadLine();

                if(Choice.Equals("N"))
                {
                    --i;
                    continue;
                }
                Console.WriteLine("");
            }

            value.Rules = tmrules;

            SaveToFile(tmrules);

            Console.WriteLine("Укажите, какое состояние будет конечным:");

            value.CurrentState = new State(0);
            value.EndState = new State(Convert.ToInt32(Console.ReadLine()));

            List<Ribbon> Ribbons = new List<Ribbon>();

            Ribbons.Add(new Ribbon(new List<char> { 'l', '1', '>', '1', '1', 'l' }));
            Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));
            Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));

            Ribbons[0].CurrentPosition = 1;
            Ribbons[1].CurrentPosition = 1;
            Ribbons[2].CurrentPosition = 1;

            value.Ribbons = Ribbons;
            value.DoAlgorithm();

            
        }
    
        static void SaveToFile(List<Rule> rules)
        {
            using (StreamWriter sw = new StreamWriter("rules.txt"))
            {
                foreach (var rule in rules)
                {
                    sw.WriteLine(JsonHelper.JsonSerializer<Rule>(rule));
                }
            }
        }
    }
}
