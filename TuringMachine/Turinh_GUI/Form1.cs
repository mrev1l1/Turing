using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Turing.Core;
using System.IO;
using System.Collections.Generic;

namespace Turinh_GUI
{
    public partial class Form1 : Form
    {
        private TuringMachine machine;
        private List<Rule> rules;

        public Form1()
        {
            InitializeComponent();

            machine = new TuringMachine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] rulesToSave = RulesTextBox.Lines;

            List<Rule> parsedRules = new List<Rule>();

            foreach (var line in rulesToSave)
            {
                if (line.Equals(string.Empty)) continue;

                string[] ruleParts = line.Split('-');

                Rule rule = new Rule();

                rule = this.ParseRulePart(ruleParts[0], ruleParts[1]);

                parsedRules.Add(rule);
            }

            using (StreamWriter sw = new StreamWriter("rules.txt"))
            {
                foreach (var rule in rules)
                {
                    sw.WriteLine(JsonConvert.SerializeObject(rule));
                }
            }
        }

        private Rule ParseRulePart(string s1, string s2)
        {
            Rule rule = new Rule();

            bool isShift = false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Equals('q'))
                {
                    rule.CurrentState = new State((int)Char.GetNumericValue(s1[i + 1]));

                    continue;
                }

                if (s1[i].Equals('('))
                {
                    rule.CurrentSymbols = new List<char>();

                    while (!s1[++i].Equals(')'))
                    {
                        rule.CurrentSymbols.Add(s1[i]);
                    }
                }
            }

            for (int i = 0; i < s2.Length; i++)
            {
                if (s1[i].Equals('q'))
                {
                    rule.NextState = new State((int)Char.GetNumericValue(s2[i + 1]));

                    continue;
                }

                if (s2[i].Equals('(') && !isShift)
                {
                    rule.NextSymbols = new List<char>();

                    isShift = true;

                    while (!s2[++i].Equals(')'))
                    {
                        rule.NextSymbols.Add(s2[i]);
                    }
                }

                if (isShift)
                {
                    ++i;
                    rule.Shifts = new List<char>();

                    while (!s2[++i].Equals(')'))
                    {
                        rule.Shifts.Add(s2[i]);
                    }
                }
            }

            return rule;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rules = new List<Rule>();

            string s = string.Empty;

            using (StreamReader sr = new StreamReader("rules.txt"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    Rule rule = JsonConvert.DeserializeObject<Rule>(s);

                    RulesTextBox.Text += rule.ToString();

                    RulesTextBox.Text += Environment.NewLine;

                    rules.Add(rule);
                }
            }
        }

        private void DoAlgorithmButton_Click(object sender, EventArgs e)
        {
            int SelectedCount = Convert.ToInt32(RibbonQuantitySelector.SelectedItem);
            String[] RibbonsContent = RibbonsContentTextBox.Lines;
            int ActualCount = RibbonsContent.Length;

            if(ActualCount!=SelectedCount)
            {
                //TODO Handle Exception
            }

            machine.Rules = rules;

            List<Ribbon> Ribbons = new List<Ribbon>();
            for (int i = 0; i < ActualCount; i++)
            {
                Ribbons.Add(new Ribbon(RibbonsContent[i].ToCharArray()));
            }

            machine.Ribbons = Ribbons;
            machine.CurrentState = new State(0);
            machine.EndState = new State(-1);

            for (int i = 0; i < Ribbons.Count; i++)
                machine.Ribbons[i].CurrentPosition = 1;

            var Result =  machine.DoAlgorithm();

            LogTextBox.Lines = Result.Key.ToArray();
            LogTextBox.ScrollBars = ScrollBars.Vertical;
            LogTextBox.ScrollToCaret();

            StepCountLabel.Text = "Потребовалось " + Result.Value.ToString() + " шагов";
        }
    }
}
