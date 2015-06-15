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

        public Form1()
        {
            InitializeComponent();

            machine = new TuringMachine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rule rule = new Rule();

            rule.CurrentState = new State(0);

            System.Collections.Generic.List<char> currentSymbols = new System.Collections.Generic.List<char>();

            currentSymbols.Add('a');

            currentSymbols.Add('b');

            rule.CurrentSymbols = currentSymbols;

            rule.NextState = new State(1);

            System.Collections.Generic.List<char> nextSymbols = new System.Collections.Generic.List<char>();

            nextSymbols.Add('b');

            rule.NextSymbols = nextSymbols;

            System.Collections.Generic.List<char> shifts = new System.Collections.Generic.List<char>();

            shifts.Add('R');

            rule.Shifts = shifts;

            using (StreamWriter sw = new StreamWriter("rules.txt"))
            {
                sw.WriteLine(JsonConvert.SerializeObject(rule));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Rule> rules = new List<Rule>();

            string s = string.Empty;

            using (StreamReader sr = new StreamReader("rules.txt"))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    Rule rule = JsonConvert.DeserializeObject<Rule>(s);

                    RibbonsContentTextBox.Text += rule.ToString();

                    RibbonsContentTextBox.Text += Environment.NewLine;

                    rules.Add(rule);
                }
            }
        }
    }
}
