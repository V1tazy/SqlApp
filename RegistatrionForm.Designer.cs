namespace SqlApp
{
    partial class RegistatrionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistatrionForm));
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnLogin = new Button();
            userSurnameField = new TextBox();
            userNameField = new TextBox();
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
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(userSurnameField);
            panel1.Controls.Add(userNameField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 450);
            panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(493, 218);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 29);
            textBox2.TabIndex = 7;
            textBox2.UseSystemPasswordChar = true;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(95, 218);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(206, 29);
            textBox1.TabIndex = 6;
            textBox1.UseSystemPasswordChar = true;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Crimson;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 128);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLogin.ForeColor = SystemColors.Info;
            btnLogin.Location = new Point(212, 333);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(343, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Зарегестрироваться";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // userSurnameField
            // 
            userSurnameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userSurnameField.Location = new Point(493, 153);
            userSurnameField.Name = "userSurnameField";
            userSurnameField.Size = new Size(206, 29);
            userSurnameField.TabIndex = 4;
            userSurnameField.Enter += userSurnameField_Enter;
            userSurnameField.Leave += userSurnameField_Leave;
            // 
            // userNameField
            // 
            userNameField.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userNameField.Location = new Point(95, 153);
            userNameField.Multiline = true;
            userNameField.Name = "userNameField";
            userNameField.PasswordChar = '*';
            userNameField.Size = new Size(206, 29);
            userNameField.TabIndex = 3;
            userNameField.UseSystemPasswordChar = true;
            userNameField.Enter += userNameField_Enter;
            userNameField.Leave += userNameField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(418, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 197);
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
            panel2.Size = new Size(767, 119);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(737, 0);
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
            label1.Location = new Point(221, 39);
            label1.Name = "label1";
            label1.Size = new Size(267, 44);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.White;
            button1.Location = new Point(212, 395);
            button1.Name = "button1";
            button1.Size = new Size(343, 43);
            button1.TabIndex = 8;
            button1.Text = "Авторизоваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RegistatrionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistatrionForm";
            Text = "RegistatrionForm";
            MouseDown += RegistatrionForm_MouseDown;
            MouseMove += RegistatrionForm_MouseMove;
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
        private Button btnLogin;
        private TextBox userSurnameField;
        private TextBox userNameField;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
    }
}