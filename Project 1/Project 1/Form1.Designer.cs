namespace Project_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 149);
            label1.Name = "label1";
            label1.Size = new Size(73, 16);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(40, 194);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            label2.Click += label2_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(43, 168);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(205, 23);
            txtuser.TabIndex = 2;
            txtuser.TextChanged += textBox1_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(43, 213);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(205, 23);
            txtpass.TabIndex = 3;
            txtpass.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 157, 88);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(43, 279);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 4;
            button1.Text = "Login";
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
            button2.Location = new Point(151, 279);
            button2.Name = "button2";
            button2.Size = new Size(97, 23);
            button2.TabIndex = 5;
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
            button3.Location = new Point(110, 342);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Register";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(71, 323);
            label4.Name = "label4";
            label4.Size = new Size(151, 16);
            label4.TabIndex = 8;
            label4.Text = "Don't Have An Account?";
            label4.Click += label4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(43, 242);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 17);
            checkBox1.TabIndex = 9;
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
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 411);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.SizeNS;
            DoubleBuffered = true;
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
    }
}