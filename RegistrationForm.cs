using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Drawing;

namespace AllChat
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            DbConnector.conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!regLock && correct())
            {
                if (free(nickBox.Text, "Nickname") && free(emailBox.Text, "Email"))
                {
                    Random rnd = new Random();
                    int rndNumber = rnd.Next(100000, 999999);
                    Account.verificationCode = rndNumber;
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("aallchat@yandex.ru");
                    mail.To.Add(new MailAddress($"{emailBox.Text}"));
                    mail.Subject = "AllChat service";
                    mail.Body = $"Your verification code is **{rndNumber}**";

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.yandex.ru";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("aallchat@yandex.ru", "harut131491");
                    client.Send(mail);
                    var veryForm = new VerificationForm();

                    if (radioButton1.Checked)
                        Account.gender = "Woman";
                    else
                        Account.gender = "Man";
                    Account.nickname = nickBox.Text;
                    Account.name = nameBox.Text;
                    Account.surname = surnameBox.Text;
                    Account.email = emailBox.Text;
                    Account.password = passwordBox.Text;
                    Account.date = DateTime.Now.ToString("dd/MM/yyyy");
                    veryForm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Nickname or Email already used!");
                DbConnector.connSelector.Close();
            }
            else
            {
                MessageBox.Show("Fill out all of the required fields correctly");
            }
        }
        private bool free(string value,string value2)
        {
            DbConnector.connSelector.Open();
            MySqlCommand mysql_query = DbConnector.connSelector.CreateCommand();
            mysql_query.CommandText = $"SELECT {value2} FROM accounts";
            MySqlDataReader mysql_result;
            mysql_result = mysql_query.ExecuteReader();
            while (mysql_result.Read())
            {
                if (value == mysql_result.GetString(0).ToString())
                {
                    return false;
                }
            }
            DbConnector.connSelector.Close();
            return true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var signForm = new AuthForm();
            signForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var auth = new AuthForm();
            auth.Show();
            this.Close();
        }

        static bool regLock = true;
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (emailBox.Text.Contains("@"))
            {
                if (emailBox.Text.Contains(".com") || emailBox.Text.Contains(".ru"))
                {
                    emailBox.ForeColor = Color.Green;
                    regLock = false;
                }
            }
            else
            {
                emailBox.ForeColor = Color.Red;
                regLock = true;
            }
        }
        private bool correct()
        {
            if (nickBox.Text.Length > 4 || nameBox.Text.Length > 4 || emailBox.Text.Length > 9)
                return true;
            else
                return false;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text.Length < 6)
            {
                passwordBox.ForeColor = Color.Red;
                regLock = true;
            }
            else
            {
                passwordBox.ForeColor = Color.Green;
                regLock = false;
            }
        }
        int tmpX, tmpY;
        bool mousedown;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            mousedown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var formm = new Form2();
            formm.Show();
            this.Close();
        }
    }
}
