using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
   
    public partial class MailSend : Form
    {

        public class EmailClassifier
        {
            public int Classify(string subject, string body)
            {
                if (ContainsIgnoreCase(subject, "важливе") || ContainsIgnoreCase(body, "важливе") || ContainsIgnoreCase(subject, "термінове") || ContainsIgnoreCase(body, "термінове") || ContainsIgnoreCase(subject, "офіційне") || ContainsIgnoreCase(body, "офіційне"))
                {
                    return 2;
                }
                else if (ContainsIgnoreCase(subject, "акція") || ContainsIgnoreCase(body, "акція") || ContainsIgnoreCase(subject, "знижка") || ContainsIgnoreCase(body, "знижка") || ContainsIgnoreCase(subject, "подарунок") || ContainsIgnoreCase(body, "подарунок") || ContainsIgnoreCase(subject, "спеціальна пропозиція") || ContainsIgnoreCase(body, "спеціальна пропозиція"))
                {
                    return 3;
                }
                else if (ContainsIgnoreCase(subject, "спам") || ContainsIgnoreCase(body, "спам") || ContainsIgnoreCase(subject, "реклама") || ContainsIgnoreCase(body, "реклама") || ContainsIgnoreCase(subject, "пропозиція") || ContainsIgnoreCase(body, "пропозиція"))
                {
                    return 1;
                }
                else
                {
                    return 1;
                }
            }

            private bool ContainsIgnoreCase(string source, string value)
            {
                return source.IndexOf(value, StringComparison.OrdinalIgnoreCase) >= 0;
            }
        }
        public MailSend()
        {
            InitializeComponent();
            Tema.Text = "Введіть тему вашого листа";
            Tema.ForeColor = Color.Gray;

            MailText.Text = "Введіть текст листа";
            MailText.ForeColor = Color.Gray;

            ToWhom.Text = "Кому надіслати листа";
            ToWhom.ForeColor = Color.Gray;
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

        private void Button2_Click(object sender, EventArgs e)
        {
           
            
        }

        private void Review_Click(object sender, EventArgs e)
        {
            this.Close();
            MailsRev mailrev = new MailsRev();
            mailrev.Show();
            
        }


        private void Send_Click(object sender, EventArgs e)
        {
            var classifier = new EmailClassifier();
            int classification = classifier.Classify(Tema.Text, MailText.Text);

            string connectionString = "server=localhost;port=3306;username=root;password=root;database=proger;";
            string query = "INSERT INTO Mails (Tema, MailText, FromWhom, ToWhom, Class) VALUES (@Tema, @MailText, @FromWhom, @ToWhom, @Class)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@Tema", Tema.Text);
                    command.Parameters.AddWithValue("@MailText", MailText.Text);
                    command.Parameters.AddWithValue("@FromWhom", LoginForm.CurrentUserName);
                    command.Parameters.AddWithValue("@ToWhom", ToWhom.Text);
                    command.Parameters.AddWithValue("@Class", classification);
                  

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Лист успішно відправлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка відправки листа: {ex.Message}");
            }
        }

      

       


        private void Tema_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tema.Text))
            {
                Tema.Text = "Введіть тему вашого листа";
                Tema.ForeColor = Color.Gray;
            }
        }

        private void ToWhom_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ToWhom.Text))
            {
                ToWhom.Text = "Кому надіслати листа";
                ToWhom.ForeColor = Color.Gray;
            }
        }

        private void MailText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MailText.Text))
            {
                MailText.Text = "Введіть текст листа";
                MailText.ForeColor = Color.Gray;
            }
        }

        private void Tema_Enter(object sender, EventArgs e)
        {
            if (Tema.Text == "Введіть тему вашого листа")
            {
                Tema.Text = "";
                Tema.ForeColor = Color.Black;
            }
        }

        private void ToWhom_Enter(object sender, EventArgs e)
        {
            if (ToWhom.Text == "Кому надіслати листа")
            {
                ToWhom.Text = "";
                ToWhom.ForeColor = Color.Black;
            }
        }

        private void MailText_Enter(object sender, EventArgs e)
        {
            if (MailText.Text == "Введіть текст листа")
            {
                MailText.Text = "";
                MailText.ForeColor = Color.Black;
            }
        }
    }
}

