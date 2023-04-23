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
    public partial class MailsRev : Form
    {
        

        private void LoadEmails(int category)
        {

            string connectionString = "server=localhost;port=3306;username=root;password=root;database=proger;";
            string query;

            if (category == -1)
            {
                query = "SELECT * FROM Mails";
            }
            else
            {
                query = $"SELECT * FROM Mails WHERE Class = {category}";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                emailsList.Items.Clear();

                while (reader.Read())
                {
                    string subject = reader["Tema"].ToString();
                    string toWhom = reader["ToWhom"].ToString();

                   
                    emailsList.Items.Add($"{subject} - {toWhom}");
                }
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            LoadEmails(-1);
        }

        private void showSpamButton_Click(object sender, EventArgs e)
        {
            LoadEmails(1);
        }

        private void showImportantButton_Click(object sender, EventArgs e)
        {
            LoadEmails(2);
        }

        private void showPromotionsButton_Click(object sender, EventArgs e)
        {
            LoadEmails(3);

        }

        public MailsRev()
        {
            InitializeComponent();
            LoadEmails(-1);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MailSend mailsend = new MailSend();
            mailsend.Show();
        }

        private void emailsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Mainpanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void Mainpanel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        Point lastpoint;

       
    }
}
