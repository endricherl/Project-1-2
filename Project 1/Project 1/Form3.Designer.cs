namespace Project_1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panelMenu = new Panel();
            buttonLogOut = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(buttonLogOut);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 583);
            panelMenu.TabIndex = 0;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.FromArgb(15, 157, 88);
            buttonLogOut.FlatAppearance.BorderSize = 0;
            buttonLogOut.FlatStyle = FlatStyle.Flat;
            buttonLogOut.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.ForeColor = Color.Gainsboro;
            buttonLogOut.Location = new Point(12, 522);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(193, 49);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "Log Out";
            buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(51, 51, 76);
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Gainsboro;
            button4.Location = new Point(0, 280);
            button4.Name = "button4";
            button4.Size = new Size(220, 60);
            button4.TabIndex = 3;
            button4.Text = "History";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(51, 51, 76);
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(0, 220);
            button3.Name = "button3";
            button3.Size = new Size(220, 60);
            button3.TabIndex = 2;
            button3.Text = "Stock List";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(51, 51, 76);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 160);
            button2.Name = "button2";
            button2.Size = new Size(220, 60);
            button2.TabIndex = 1;
            button2.Text = "Transactions";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 51, 76);
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(0, 100);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Center;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 100);
            panelLogo.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 583);
            Controls.Add(panelMenu);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button buttonLogOut;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelLogo;
    }
}