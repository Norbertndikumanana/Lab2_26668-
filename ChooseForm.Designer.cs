namespace Lab2_Norbert_NDIKUMANA_26668
{
    partial class ChooseForm
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
            btnBicycle = new Button();
            btnMushroom = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnBicycle
            // 
            btnBicycle.Location = new Point(64, 134);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(259, 118);
            btnBicycle.TabIndex = 0;
            btnBicycle.Text = "bicycle";
            btnBicycle.UseVisualStyleBackColor = true;
            btnBicycle.Click += btnBicycle_Click;
            // 
            // btnMushroom
            // 
            btnMushroom.Location = new Point(441, 134);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(259, 118);
            btnMushroom.TabIndex = 1;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = true;
            btnMushroom.Click += btnMushroom_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(261, 275);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(259, 118);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnMushroom);
            Controls.Add(btnBicycle);
            Name = "ChooseForm";
            Text = "ChooseForm";
            Load += ChooseForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnBicycle;
        private Button btnMushroom;
        private Button btnLogout;
    }
}