using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;

namespace AllChat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Account.name;
            timer1.Enabled = true;
            try
            {
                DbConnector.connSelector.Open();
            }
            catch
            {
                //MessageBox.Show("Connection error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox.Text != "")
                {
                    timer1.Enabled = true;
                    string query = $"INSERT INTO globalchat (Nickname,Text,File,Date) VALUES ('{Account.nickname}','{textBox.Text}','0','{DateTime.Now.ToString("dd/MM/yyyy")}')";
                    MySqlScript script = new MySqlScript(DbConnector.connSelector, query);
                    int count = script.Execute();
                    textBox.Text = "";
                }
                else
                    textBox.BackColor = Color.Brown;
            }
            catch
            {
                MessageBox.Show("Connection error");
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand mysql_query = DbConnector.connSelector.CreateCommand();
                mysql_query.CommandText = $"SELECT ID,Nickname,Text FROM globalchat";
                MySqlDataReader mysql_result;
                mysql_result = mysql_query.ExecuteReader();
                while (mysql_result.Read())
                {
                    if (int.Parse(mysql_result.GetString(0).ToString()) > Account.id)
                    {
                        Account.id = int.Parse(mysql_result.GetString(0).ToString());
                        chatRichBox.Text += mysql_result.GetString(1).ToString() + ": " + mysql_result.GetString(2).ToString() + '\n';
                        chatRichBox.SelectionStart = chatRichBox.TextLength;
                        chatRichBox.ScrollToCaret();
                    }
                }
                mysql_result.Close();
            }
            catch
            {
                MessageBox.Show("Connection interrupted");
                var ff = new AuthForm();
                ff.Show();
                this.Close();
            }

        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    timer1.Enabled = true;
                    string query = $"INSERT INTO globalchat (Nickname,Text,File,Date) VALUES ('{Account.nickname}','{textBox.Text}','0','{DateTime.Now.ToString("dd/MM/yyyy")}')";
                    MySqlScript script = new MySqlScript(DbConnector.connSelector, query);
                    int count = script.Execute();
                    textBox.Text = "";
                }
        }
            catch
            {
                MessageBox.Show("Connection error");
            }
}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Harut Hakobyan  v0.2");
        }
        int tmpX, tmpY;
        bool mousedown;
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            mousedown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "1";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "2";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "3";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "4";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "5";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "6";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "7";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "8";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "9";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "10";
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "11";
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "12";
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "13";
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "14";
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "15";
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "16";
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "17";
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "18";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "19";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox.Text += "smileHcOdE" + "20";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon...");
        }

        private void onlinePeoplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<string> online = new List<string>();

            //try
            //{
            //    MySqlCommand mysql_query = DbConnector.connSelector.CreateCommand();
            //    mysql_query.CommandText = $"SELECT Nickname FROM globalchat WHERE Online = 'Online'";
            //    MySqlDataReader mysql_result;
            //    mysql_result = mysql_query.ExecuteReader();
            //    while (mysql_result.Read())
            //    {
            //        online.Add(mysql_result.GetString(0).ToString());
            //    }
            //    mysql_result.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Connection interrupted");
            //    var ff = new AuthForm();
            //    ff.Show();
            //    this.Close();
            //}
            MessageBox.Show("Comming soon...");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.BackColor = Color.Black;
        }

        private void privateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process toKill = Process.GetCurrentProcess();
                toKill.Kill();
            }
            catch
            {
                this.Close();
            }
        }
    }
}
