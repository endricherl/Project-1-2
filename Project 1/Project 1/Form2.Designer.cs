namespace Project_1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtsetuser = new TextBox();
            txtsetpass = new TextBox();
            txtconfirm = new TextBox();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 157, 88);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(43, 308);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(15, 157, 88);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(148, 308);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(15, 157, 88);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(105, 362);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 140);
            label1.Name = "label1";
            label1.Size = new Size(73, 16);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 185);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 230);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 5;
            label3.Text = "Confirm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 343);
            label4.Name = "label4";
            label4.Size = new Size(167, 16);
            label4.TabIndex = 6;
            label4.Text = "Already Have An Account?";
            // 
            // txtsetuser
            // 
            txtsetuser.Location = new Point(43, 159);
            txtsetuser.Name = "txtsetuser";
            txtsetuser.Size = new Size(205, 23);
            txtsetuser.TabIndex = 7;
            // 
            // txtsetpass
            // 
            txtsetpass.Location = new Point(43, 204);
            txtsetpass.Name = "txtsetpass";
            txtsetpass.PasswordChar = '*';
            txtsetpass.Size = new Size(205, 23);
            txtsetpass.TabIndex = 8;
            // 
            // txtconfirm
            // 
            txtconfirm.Location = new Point(43, 249);
            txtconfirm.Name = "txtconfirm";
            txtconfirm.PasswordChar = '*';
            txtconfirm.Size = new Size(205, 23);
            txtconfirm.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(43, 278);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 17);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(86, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 116);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 411);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(txtconfirm);
            Controls.Add(txtsetpass);
            Controls.Add(txtsetuser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Register";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtsetuser;
        private TextBox txtsetpass;
        private TextBox txtconfirm;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}