using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AllChat
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            try
            {
                DbConnector.conn.Open();
            }
            catch
            {
                //MessageBox.Show("Can't connect to server...");
                //this.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var resetForm = new PassResetForm();
            resetForm.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var regForm = new RegistrationForm();
            regForm.Show();
            this.Close();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (nickOrEmailBox.Text != "")
            {
                if (passwordBox.Text != "")
                {
                    try
                    {
                        MySqlCommand mysql_query = DbConnector.conn.CreateCommand();
                        mysql_query.CommandText = $"SELECT Nickname,Name,Surname,Email,Password,Gender,Admin FROM accounts";
                        MySqlDataReader mysql_result;
                        mysql_result = mysql_query.ExecuteReader();
                        while (mysql_result.Read())
                        {
                            if (nickOrEmailBox.Text == mysql_result.GetString(0).ToString() || nickOrEmailBox.Text == mysql_result.GetString(3).ToString())
                            {
                                if (passwordBox.Text == mysql_result.GetString(4).ToString())
                                {
                                    Account.nickname = mysql_result.GetString(0).ToString();
                                    Account.email = mysql_result.GetString(3).ToString();
                                    Account.gender = mysql_result.GetString(5).ToString();
                                    Account.name = mysql_result.GetString(1).ToString();
                                    Account.surname = mysql_result.GetString(2).ToString();
                                    if (mysql_result.GetString(6).ToString() == "Admin")
                                        Account.admin = true;
                                    MessageBox.Show($"Account {Account.name} has been signed...");
                                    Account.signed = true;
                                    var form1 = new Form1();
                                    form1.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong Password!");
                                    Helper.wrong = true;
                                    break;
                                }
                                break;
                            }
                        }
                        if (!Helper.wrong)
                        {
                            if (!Account.signed)
                                MessageBox.Show("Account not found...");
                        }
                        Helper.wrong = false;
                        

                        mysql_result.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Authentication Error");
                    }
                }
                else
                {
                    passwordBox.BackColor = Color.Brown;
                    MessageBox.Show("Password box is empty");
                }
                
            }
            else
            {
                nickOrEmailBox.BackColor = Color.Brown;
                MessageBox.Show("Nickname or Email box is empty");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formm = new Form2();
            formm.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formm = new Form2();
            formm.Show();
            this.Close();
        }

        private void nickOrEmailBox_TextChanged(object sender, EventArgs e)
        {
            nickOrEmailBox.BackColor = Color.White;
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.BackColor = Color.White;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }
    }
}
