using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorAlkoholizujacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxDish.Items.Add("kufel");
            comboBoxDish.Items.Add("kieliszek 50");
            comboBoxDish.Items.Add("kieliszek 100");
            comboBoxDish.Items.Add("szklanka");

            comboBoxDrink.Items.Add("piwo");
            comboBoxDrink.Items.Add("wino");
            comboBoxDrink.Items.Add("wódka");
            comboBoxDrink.Items.Add("herbatka z prądem");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
