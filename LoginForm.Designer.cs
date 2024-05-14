namespace SqlApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            btnLogin = new Button();
            PasswordField = new TextBox();
            LoginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(PasswordField);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 450);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Crimson;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.Info;
            btnLogin.Location = new Point(83, 323);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(172, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // PasswordField
            // 
            PasswordField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordField.Location = new Point(95, 235);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(206, 29);
            PasswordField.TabIndex = 4;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(95, 142);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.PasswordChar = '*';
            LoginField.Size = new Size(206, 50);
            LoginField.TabIndex = 3;
            LoginField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 142);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(313, 119);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(286, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 30);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click;
            label3.MouseEnter += label3_MouseEnter;
            label3.MouseLeave += label3_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 38);
            label1.Name = "label1";
            label1.Size = new Size(303, 44);
            label1.TabIndex = 0;
            label1.Text = "Authorization";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.Info;
            button1.Location = new Point(61, 393);
            button1.Name = "button1";
            button1.Size = new Size(218, 45);
            button1.TabIndex = 6;
            button1.Text = "Регистрация";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox PasswordField;
        private TextBox LoginField;
        private Button btnLogin;
        private Label label3;
        private Button button1;
    }
}