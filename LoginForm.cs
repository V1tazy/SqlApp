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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.PasswordField.Size = new Size(this.PasswordField.Size.Width, 64);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string LoginUser = LoginField.Text;
            string PasswordUser = PasswordField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `[users]` WHERE `login` = @LoginUser AND `pass` = @PasswordUser", db.getConnection());
            command.Parameters.Add("@LoginUser", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@PasswordUser", MySqlDbType.VarChar).Value = PasswordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                MessageBox.Show("Yes");
            else
                MessageBox.Show("No");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.label3.ForeColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistatrionForm form = new RegistatrionForm();
            form.Show();

            this.Hide();
        }
    }
}
