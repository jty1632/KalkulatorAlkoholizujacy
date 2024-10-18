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
        private double GetDishVolume(string dish)
        {
            switch (dish) {
                case "kufel":
                    return 0.25;
                case "kieliszek 50":
                    return 0.05;
                case "kieliszek 100":
                    return 0.10;
                case "szklanka":
                    return 0.25;
            }
            return 0;
        }
        private double GetDrinkPercent(string drink)
        {
            switch (drink)
            {
                case "piwo":
                    return 0.05;
                case "wino":
                    return 0.12;
                case "wódka":
                    return 0.40;
                case "herbatka z prądem":
                    return 0.45;
            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
