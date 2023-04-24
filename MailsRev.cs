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
        private MailSend mailSendForm;

        private void LoadEmails(int category)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=proger;";
            string query;

            if (category == -1)
            {
                query = "SELECT * FROM Mails WHERE ToWhom = @currentUserName";
            }
            else
            {
                query = "SELECT * FROM Mails WHERE ToWhom = @currentUserName AND Class = @category";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@currentUserName", LoginForm.CurrentUserName);
                if (category != -1)
                {
                    command.Parameters.AddWithValue("@category", category);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                emailsList.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    string subject = row["Tema"].ToString();
                    string fromWhom = row["FromWhom"].ToString();

                    emailsList.Items.Add($"{subject} - {fromWhom}");
                }
            }
        }
        private void ShowEmail(string subject, string fromWhom)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=proger;";
            string query = "SELECT MailText FROM Mails WHERE Tema = @Tema AND FromWhom = @FromWhom AND ToWhom = @ToWhom";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Tema", subject);
                command.Parameters.AddWithValue("@FromWhom", fromWhom);
                command.Parameters.AddWithValue("@ToWhom", LoginForm.CurrentUserName);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string emailBody = reader["MailText"].ToString();
                    MessageBox.Show($"Тема: {subject}\nВід: {fromWhom}\n\n{emailBody}", "Перегляд листа");
                }
                else
                {
                    MessageBox.Show("Помилка при отриманні листа", "Помилка");
                }
            }
        }
        private void emailsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emailsList.SelectedIndex >= 0)
            {
                string selectedItem = emailsList.SelectedItem.ToString();
                string[] parts = selectedItem.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 2)
                {
                    ShowEmail(parts[0], parts[1]);
                }
            }
        }


        private void showAllButton_Click_1(object sender, EventArgs e)
        {
            LoadEmails(-1);
        }

        private void showSpamButton_Click_1(object sender, EventArgs e)
        {
            LoadEmails(1);
        }

        private void showImportantButton_Click_1(object sender, EventArgs e)
        {
            LoadEmails(2);
        }

        private void showPromotionsButton_Click_1(object sender, EventArgs e)
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

            if (mailSendForm == null || mailSendForm.IsDisposed)
            {
                mailSendForm = new MailSend();
            }

            this.Hide();
            mailSendForm.Show();

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
