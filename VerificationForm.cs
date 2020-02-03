using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using MySql.Data.MySqlClient;

namespace AllChat
{
    public partial class VerificationForm : Form
    {
        public VerificationForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        static int time = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(time > 0)
            {
                time--;
                button2.Text = time.ToString();
            }
            else
            {
                button2.Text = "Send Again";
                button2.Enabled = true;
                timer1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(100000, 999999);
            Account.verificationCode = rndNumber;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("aallchat@yandex.ru"); 
            mail.To.Add(new MailAddress("harut.hakobyan2013@mail.ru")); 
            mail.Subject = "Allchat Service";
            mail.Body = $"Your verification code is {rndNumber}";

            SmtpClient client = new SmtpClient();
            client.Host = "smtp.yandex.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("aallchat@yandex.ru", "harut131491");
            client.Send(mail);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (int.Parse(textBox1.Text) == Account.verificationCode)
                {
                    try
                    {
                        string query = $"INSERT INTO accounts (Nickname,Name,Surname,Email,Password,Gender,Date,Admin,Online) VALUES ('{Account.nickname}','{Account.name}','{Account.surname}','{Account.email}','{Account.password}','{Account.gender}','{Account.date}','User','Offline')";
                        MySqlScript script = new MySqlScript(DbConnector.conn, query);
                        int count = script.Execute();
                        MessageBox.Show("Account has been Registered!");
                        DbConnector.conn.Close();
                        var auth = new AuthForm();
                        auth.Show();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Registration Error");
                    }
                }
                else
                    MessageBox.Show("Incorrect verification code");
            }
            else
                MessageBox.Show("Fill the code");
            
        }
        int tmpX, tmpY;
        bool mousedown;
        private void button4_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formm = new RegistrationForm();
            formm.Show();
            this.Close();
        }

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
    }
}
