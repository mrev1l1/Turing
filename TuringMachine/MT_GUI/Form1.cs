using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MT_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileWithRules.ShowDialog();
        }

        private void DoAlgorithmButton_Click(object sender, EventArgs e)
        {
            int RibbonQuantity = Convert.ToInt32(RibbonQuantitySelector.SelectedItem);
            String[] RibbonContent = RibbonsContentTextBox.Lines;

            if(RibbonQuantity!=RibbonContent.Count())
            {
                //TODO : Error handling
            }

            //Считывание из файла
            {

            }


        }
    }
}
