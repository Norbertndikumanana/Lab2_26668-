namespace Lab2_Norbert_NDIKUMANA_26668
{
    partial class BicycleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStart = new Label();
            txtStart = new TextBox();
            label1 = new Label();
            txtEnd = new TextBox();
            btnCalculate = new Button();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnBack = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(21, 85);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(95, 15);
            lblStart.TabIndex = 0;
            lblStart.Text = "Start time (0-23):";
            lblStart.Click += lblStart_Click;
            // 
            // txtStart
            // 
            txtStart.Location = new Point(149, 85);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(180, 23);
            txtStart.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 154);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "End time (1-24):";
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(149, 154);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(180, 23);
            txtEnd.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(216, 213);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(113, 23);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += button1_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(42, 254);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total (RWF):";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(149, 254);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(180, 23);
            txtTotal.TabIndex = 6;
            txtTotal.TextChanged += textBox1_TextChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(149, 315);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(243, 315);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnBack);
            Controls.Add(txtTotal);
            Controls.Add(lblTotal);
            Controls.Add(btnCalculate);
            Controls.Add(txtEnd);
            Controls.Add(label1);
            Controls.Add(txtStart);
            Controls.Add(lblStart);
            Name = "BicycleForm";
            Text = "BicycleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStart;
        private TextBox txtStart;
        private Label label1;
        private TextBox txtEnd;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Button btnBack;
        private Button btnLogout;
    }
}