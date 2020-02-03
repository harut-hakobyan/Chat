using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace AllChat
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var ff = new AuthForm();
                ff.Show();
                this.Hide();
            }
            catch
            {

            }
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ff = new RegistrationForm();
            ff.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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
        int tmpX, tmpY;
        bool mousedown;

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

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            mousedown = true;
        }
    }
}
