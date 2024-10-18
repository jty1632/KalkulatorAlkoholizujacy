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
            comboBoxDrink.Items.Add("rum");
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
                case "rum":
                    return 0.45;
            }
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int pieces;
            if (comboBoxDish.SelectedIndex == -1 || comboBoxDrink.SelectedIndex == -1
                || !int.TryParse(textBoxPieces.Text, out pieces) || pieces <= 0) {
                label1.Text = "Błędne dane";
                return;
            }
            double volume = GetDishVolume(comboBoxDish.SelectedItem.ToString());
            double percent = GetDrinkPercent(comboBoxDrink.SelectedItem.ToString());

            label1.Text = $"objętość napoju: {volume * pieces}\n(czystego spirytusu {volume * pieces * percent})";
        }
    }
}
