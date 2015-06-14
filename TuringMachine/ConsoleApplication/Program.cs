using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turing.Core;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TuringMachine turing = new TuringMachine();

            InitializeTuringMachine(turing);
        }

        static void InitializeTuringMachine(TuringMachine machine)
        {
            Console.WriteLine("Введите количество лент:");
            
            machine = new TuringMachine(Convert.ToInt32(Console.ReadLine()));

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

            machine.Rules = tmrules;

            SaveToFile(tmrules);

            Console.WriteLine("Укажите, какое состояние будет конечным:");

            machine.CurrentState = new State(0);
            machine.EndState = new State(Convert.ToInt32(Console.ReadLine()));

            List<Ribbon> Ribbons = new List<Ribbon>();

            Ribbons.Add(new Ribbon(new List<char> { 'l', '1', '1', '1', '1', 'l' }));
            //Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));
            //Ribbons.Add(new Ribbon(new List<char> { 'l', 'l', 'l', 'l', 'l', 'l' }));

            Ribbons[0].CurrentPosition = 1;
            //Ribbons[1].CurrentPosition = 1;
            //Ribbons[2].CurrentPosition = 1;

            machine.Ribbons = Ribbons;

            Console.WriteLine("Запустить алгоритм? Y | N");

            string choice = Console.ReadLine();

            if (choice.Equals("Y"))
            {
                machine.DoAlgorithm();    
            }

            Console.ReadKey();
        }
    
        static void SaveToFile(List<Rule> rules)
        {
            using (StreamWriter sw = new StreamWriter("rules.txt"))
            {
                foreach (var rule in rules)
                {
                    //sw.WriteLine(JsonHelper.JsonSerializer<Rule>(rule));
                    sw.WriteLine(JsonConvert.SerializeObject(rule));
                }
            }
        }
    }
}
