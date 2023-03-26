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

namespace Test
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserNameField.Text = "Ввидите имя";
            UserNameField.ForeColor = Color.Gray;

            UserSurNameField.Text = "Ввидите фамилию";
            UserSurNameField.ForeColor = Color.Gray;
      
        }

  

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        Point lastpoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;

            }

        }

        private void UserNameField_Enter(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Ввидите имя")
            {

                UserNameField.Text = "";
                UserNameField.ForeColor = Color.Black;

            }
        }

        private void UserNameField_Leave(object sender, EventArgs e)
        {
            if (UserNameField.Text == "")
            {

                UserNameField.Text = "Ввидите имя";
                UserNameField.ForeColor = Color.Gray;
            }
        }

        private void UserSurNameField_Enter(object sender, EventArgs e)
        {
            if (UserSurNameField.Text == "Ввидите фамилию")
            {

                UserSurNameField.Text = "";
                UserSurNameField.ForeColor = Color.Black;

            }
        }

        private void UserSurNameField_Leave(object sender, EventArgs e)
        {

            if (UserSurNameField.Text == "")
            {
                UserSurNameField.Text = "Ввидите фамилию";
                UserSurNameField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (UserNameField.Text == "Ввидите имя")
            {
                MessageBox.Show("Ввидите имя");
                return;
            }
            if (UserSurNameField.Text == "Ввидите фамилию")
            {
                MessageBox.Show("Ввидите фамилию");
                return;
            }
            if (EmailEnter.Text == "")
            {
                MessageBox.Show("Ввидите логин");
                return;
            }
            if (PassEnter.Text == "")
            {
                MessageBox.Show("Ввидите пароль");
                return;
            }
            if (iskUserExist())
                return;
            


            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `Name`, `SurName`) VALUES (@login, @pass, @name, @surname);", db.getconetion()); 
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = EmailEnter.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassEnter.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurNameField.Text;

            db.openconetion();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");
            else
                MessageBox.Show("Аккаунт не создан");

            db.closeconetion();

        }
        public Boolean iskUserExist()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` =  @uL", db.getconetion());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = EmailEnter.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("ЛОГИН ЗАНЯТ");
                return true;
            }
            else
                return false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}