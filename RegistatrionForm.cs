using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlApp
{
    public partial class RegistatrionForm : Form
    {
        public RegistatrionForm()
        {
            InitializeComponent();

            userNameField.Text = "Введите имя";
            userNameField.ForeColor = Color.Gray;

            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;

            textBox1.Text = "Введите логин";
            textBox1.ForeColor = Color.Gray;

            textBox2.Text = "Введите пароль";
            textBox2.ForeColor = Color.Gray;
            textBox2.UseSystemPasswordChar = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        Point lastPoint;

        private void RegistatrionForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistatrionForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            userNameField.Text = "";
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            userSurnameField.Text = "";
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.UseSystemPasswordChar = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите пароль";
                textBox2.UseSystemPasswordChar = false;
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите логин";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите логин")
            {
                MessageBox.Show("Введите логин");
            }

            if (textBox2.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
            }

            if (userNameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
            }

            if (userSurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
            }
            if (checkUser())
                return;
            DB dB = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `[users]`( `login`, `pass`, `name`, `surname`) VALUES (@login,@pass,@name,@surname)", dB.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;

            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            dB.closeConnection();

        }

        private bool checkUser()
        {
            DB dB = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * From `[users]` where `login` = @login", dB.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть");
                return true;
            }
            else
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
