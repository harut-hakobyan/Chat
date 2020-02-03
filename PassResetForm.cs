using System;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using System.Drawing;

namespace AllChat
{
    public partial class PassResetForm : Form
    {
        static bool resetLock = true;
        public PassResetForm()
        {
            InitializeComponent();
            DbConnector.conn.Close();
            resetLock = true;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnector.connSelector.Open();
                MySqlCommand mysql_query = DbConnector.connSelector.CreateCommand();
                mysql_query.CommandText = $"SELECT Email FROM accounts";
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                while (mysql_result.Read())
                {
                    if (emailBox.Text == mysql_result.GetString(0).ToString())
                    {
                        ////////Mail Send//////
                        Random rnd = new Random();
                        int rndNumber = rnd.Next(100000, 999999);
                        Account.resetCode = rndNumber;
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("aallchat@yandex.ru");
                        mail.To.Add(new MailAddress($"{emailBox.Text}"));
                        mail.Subject = "AllChat service";
                        mail.Body = $"Your reset code is **{rndNumber}**";

                        SmtpClient client = new SmtpClient();
                        client.Host = "smtp.yandex.ru";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential("aallchat@yandex.ru", "harut131491");
                        client.Send(mail);
                        ///////////////////////
                        emailPanel.Visible = false;
                        resetCodePanel.Visible = true;
                    }
                    else
                        emailBox.ForeColor = Color.Red;
                }
                DbConnector.connSelector.Close();
            }
            catch
            {
                MessageBox.Show("Connection error");
            }

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (resetCodeBox.Text == Account.resetCode.ToString())
            {
                resetCodePanel.Visible = false;
                newPassPanel.Visible = true;
            }
            else
                MessageBox.Show("Code is Wrong");
        }

        private void newPassOkButton_Click(object sender, EventArgs e)
        {
            try
            {
                isNotEquals();
                if (resetLock == false)
                {
                    DbConnector.connSelector.Open();
                    MySqlCommand mysql_query = DbConnector.connSelector.CreateCommand();
                    mysql_query.CommandText = $"UPDATE accounts SET Password = '{newPassBox1.Text}' Where Email = '{emailBox.Text}'";
                    MySqlDataReader mysql_result;
                    mysql_result = mysql_query.ExecuteReader();
                    MessageBox.Show("Passowrd has been reset");
                    mysql_result.Close();
                    DbConnector.conn.Close();
                    this.Close();
                    AuthForm form = new AuthForm();
                    form.Show();
                }
                else
                    MessageBox.Show("Password is not valid");
            }
            catch
            {
                MessageBox.Show("Connection error");
            }



        }
        
        private void isNotEquals()
        {
            if (newPassBox1.Text.Length >=6 && newPassBox1.Text == newPassBox2.Text)
            {
                newPassBox1.ForeColor = Color.Green;
                newPassBox2.ForeColor = Color.Green;
                resetLock = false;
            }
            else
            {
                newPassBox1.ForeColor = Color.Red;
                newPassBox2.ForeColor = Color.Red;
                resetLock = true;
            }
        }

        private void newPassBox1_TextChanged(object sender, EventArgs e)
        {
            isNotEquals();
        }

        private void newPassBox2_TextChanged(object sender, EventArgs e)
        {
            isNotEquals();
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            emailBox.ForeColor = Color.White;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var form22 = new Form2();
            form22.Show();
            this.Close();
        }
        int tmpX, tmpY;
        bool mousedown;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            mousedown = true;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formm = new AuthForm();
            formm.Show();
            this.Close();
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
    }
}
