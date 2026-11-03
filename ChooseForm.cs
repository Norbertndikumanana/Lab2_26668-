using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_Norbert_NDIKUMANA_26668
{
    public partial class ChooseForm : Form

    {
        private LoginForm login;
        private bool navigating = false;
        public ChooseForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;

         
            btnLogout.Click += btnLogout_Click;
            this.FormClosed += ChooseForm_FormClosed;
        }

        private void ChooseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
          
            navigating = true;
            BicycleForm bicycle = new BicycleForm(this, login);
            bicycle.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            

            navigating = true;
            Mushroom mushroom = new Mushroom(this, login);
           mushroom.Show();
            this.Hide();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            navigating = true;
            login.Show();
            this.Close();
        }
        
        private void ChooseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
        public void ShowAgain()
        {
            navigating = false;
            this.Show();
        }
    }
}
