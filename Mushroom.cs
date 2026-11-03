using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_Norbert_NDIKUMANA_26668
{
    public partial class Mushroom : Form
    {
        private ChooseForm choose;
        private LoginForm login;
        private bool navigating = false;
        private int step = 0;

        public Mushroom(ChooseForm choose, LoginForm login)
        {
            InitializeComponent();
            this.choose = choose;
            this.login = login;
            this.FormClosed += Mushroom_FormClosed;
            Restart();
        }
        private void Mushroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
        private void Restart()
        {
            step = 0;
            btnYes.Enabled = true;
            btnNo.Enabled = true;
            ShowQuestion();
        }
        private void ShowQuestion()
        {
            switch (step)
            {
                case 0: lblQuestion.Text = "Does your mushroom have a ring?"; break;
                case 1: lblQuestion.Text = "Does your mushroom grow in a forest?"; break;
                case 2: lblQuestion.Text = "Does your mushroom have gills?"; break;
                case 3:
                case 4: lblQuestion.Text = "Does your mushroom have a convex cup?"; break;
            }
        }
        private void Answer(bool yes)
        {
            switch (step)
            {
                case 0:                                   // ring?
                    step = yes ? 1 : 2;
                    break;
                case 1:                                   // forest? (has a ring)
                    if (yes) { Result("Amanite tue-mouche"); return; }
                    step = 3;
                    break;
                case 2:                                   // gills? (no ring)
                    if (!yes) { Result("Cepe de Bordeaux"); return; }
                    step = 4;
                    break;
                case 3:                                   // convex cup? (ring, meadow)
                    Result(yes ? "Agaric Jaunissant" : "Coprin chevelu");
                    return;
                case 4:                                   // convex cup? (no ring, gills)
                    Result(yes ? "Pied bleu" : "Girolle");
                    return;
            }
            ShowQuestion();
        }
        private void Result(string name)
        {
            lblQuestion.Text = "Your mushroom is: " + name;
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            MessageBox.Show("Your mushroom is: " + name, "Result",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Answer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Answer(false);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            navigating = true;
            choose.ShowAgain();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            navigating = true;
            choose.Close();
            login.Show();
            this.Close();
        }
        private void MushroomForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}
