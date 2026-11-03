using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2_Norbert_NDIKUMANA_26668
{
    public partial class BicycleForm : Form
    {
        private ChooseForm choose;
        private LoginForm login;
        private bool navigating = false;
        public BicycleForm(ChooseForm choose, LoginForm login)
        {
            InitializeComponent();
            this.choose = choose;
            this.login = login;
            this.FormClosed += BicycleForm_FormClosed;
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start, end;

            // whole numbers only (no decimals, no text)
            if (!int.TryParse(txtStart.Text, out start) || !int.TryParse(txtEnd.Text, out end))
            {
                MessageBox.Show("Please enter whole numbers only (no decimals).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start < 0 || start > 23)
            {
                MessageBox.Show("Start time must be between 0 and 23.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (end < 1 || end > 24)
            {
                MessageBox.Show("End time must be between 1 and 24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Start time must be less than end time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int hour = start; hour < end; hour++)
            {
                total += RateForHour(hour);
            }

            txtTotal.Text = total.ToString();
            MessageBox.Show("You must pay " + total + " RWF.",
                "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        // Rate for the hour that starts at 'hour'
        private int RateForHour(int hour)
        {
            if (hour < 7 || hour >= 21) return 500;    // 0-7 and 21-24
            if (hour < 14 || hour >= 19) return 1000;  // 7-14 and 19-21
            return 1500;                               // 14-19
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
        private void BicycleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!navigating)
            {
                Application.Exit();
            }
        }
    }
}
