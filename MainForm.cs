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
   
    public partial class MainForm : Form
    {

        public class EmailClassifier
        {
            public int Classify(string subject, string body)
            {
                if (subject.Contains("спам") || body.Contains("спам"))
                {
                    return 1; 
                }
                else if (subject.Contains("важливе") || body.Contains("важливе"))
                {
                    return 2; 
                }
                else if (subject.Contains("акція") || body.Contains("акція"))
                {
                    return 3; 
                }
                else
                {
                    return 1; 
                }
            }
        }
        public MainForm()
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
            MailRev.Visible = false;
            Send.Visible = true;
            MailText.Visible = true;
            Tema.Visible = true;
            ToWhom.Visible = true;
            
        }

        private void Review_Click(object sender, EventArgs e)
        {
            MailRev.Visible = true;
            Send.Visible = false;
            MailText.Visible = false;
            ToWhom.Visible = false;
            Tema.Visible = false;
            
        }


        private void Send_Click(object sender, EventArgs e)
        {


            
            var classifier = new EmailClassifier();
            int classification = classifier.Classify(Tema.Text, MailText.Text);

            
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=proger;";
            string query = "INSERT INTO Mails (Tema, MailText, ToWhom, Class) VALUES (@Tema, @MailText, @ToWhom, @Class)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Tema", Tema.Text);
                command.Parameters.AddWithValue("@MailText", MailText.Text);
                command.Parameters.AddWithValue("@ToWhom", ToWhom.Text);
                command.Parameters.AddWithValue("@Class", classification); 

                command.ExecuteNonQuery();
            }


        }

        private void Tema_MouseEnter(object sender, EventArgs e)
        {
            if (Tema.Text == "Введіть тему вашого листа")
            {
                Tema.Text = "";
                Tema.ForeColor = Color.Black;
            }
        }

        private void Tema_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Tema.Text))
            {
                Tema.Text = "Введіть тему вашого листа";
                Tema.ForeColor = Color.Gray;
            }
        }

        private void ToWhom_MouseEnter(object sender, EventArgs e)
        {
            if (ToWhom.Text == "Кому надіслати листа")
            {
                ToWhom.Text = "";
                ToWhom.ForeColor = Color.Black;
            }
        }

        private void ToWhom_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ToWhom.Text))
            {
                ToWhom.Text = "Кому надіслати листа";
                ToWhom.ForeColor = Color.Gray;
            }
        }

        private void MailText_MouseEnter(object sender, EventArgs e)
        {
            if (MailText.Text == "Введіть текст листа")
            {
                MailText.Text = "";
                MailText.ForeColor = Color.Black;
            }
        }

        private void MailText_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MailText.Text))
            {
                MailText.Text = "Введіть текст листа";
                MailText.ForeColor = Color.Gray;
            }
        }
    }
}

