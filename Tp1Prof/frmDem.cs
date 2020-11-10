using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using tp1dll;


namespace Tp1Prof
{
    public partial class Form1 : Form
    {
        pays unPays;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        lstcontinent.Items.Add("Europe");
        lstcontinent.Items.Add("Amérique");
        lstcontinent.Items.Add("Asie");
        lstcontinent.Items.Add("Océanie");
        lstcontinent.Items.Add("Afrique");

        lstmonnaie.Items.Add("Euro");
        lstmonnaie.Items.Add("Livre S");
        lstmonnaie.Items.Add("Dollar");
        lstmonnaie.Items.Add("Yen");
        }

        private void cmdcreer_Click(object sender, EventArgs e)
        {
            unPays = new pays(txtnom.Text, Convert.ToString(lstcontinent.SelectedItem), Convert.ToInt16(txthabitant.Text), Convert.ToSingle(txtsuperficie.Text), Convert.ToString(lstmonnaie.SelectedItem));
        MessageBox.Show("Le pays a été créé");
        }

        private void cmdcaract_Click(object sender, EventArgs e)
        {
            lblCaract.Text = "Continent : " + unPays.getcontinent() + "\nPays : " + unPays.getnom() + "\nMonnaie : " + unPays.getmonnaie() + "\nHabitants : " + unPays.gethabitant() + "\nSuperficie : " + unPays.getsuperficie();
        }

        private void cmdsuperfhab_Click(object sender, EventArgs e)
        {
            lblCaract.Text = "Superficie par habitant : " + Math.Round(unPays.supefhab(), 3);
        }

        private void cmdnbhab_Click(object sender, EventArgs e)
        {
            unPays.sethabitant(Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("Indiquez le nombre d'habitant du " + unPays.getnom())));
        MessageBox.Show("Modification effectuée.");
        }

        private void cmdmonnaie_Click(object sender, EventArgs e)
        {
            unPays.setmonnaie(Convert.ToString(lstmonnaie.SelectedItem));
        MessageBox.Show("Modification effectuée.");
        }

    }
}

