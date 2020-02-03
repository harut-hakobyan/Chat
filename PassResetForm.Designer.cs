namespace AllChat
{
    partial class PassResetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassResetForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newPassPanel = new System.Windows.Forms.Panel();
            this.newPassOkButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassBox2 = new System.Windows.Forms.TextBox();
            this.newPassBox1 = new System.Windows.Forms.TextBox();
            this.resetCodePanel = new System.Windows.Forms.Panel();
            this.OkButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.resetCodeBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emailPanel.SuspendLayout();
            this.newPassPanel.SuspendLayout();
            this.resetCodePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot your password? Let\'s get\r\nnew one.\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Address";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailBox.Location = new System.Drawing.Point(11, 27);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(204, 20);
            this.emailBox.TabIndex = 2;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResetButton.Location = new System.Drawing.Point(34, 53);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // emailPanel
            // 
            this.emailPanel.BackColor = System.Drawing.Color.Transparent;
            this.emailPanel.Controls.Add(this.cancelButton);
            this.emailPanel.Controls.Add(this.ResetButton);
            this.emailPanel.Controls.Add(this.emailBox);
            this.emailPanel.Controls.Add(this.label2);
            this.emailPanel.Location = new System.Drawing.Point(15, 91);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(224, 85);
            this.emailPanel.TabIndex = 4;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelButton.Location = new System.Drawing.Point(115, 53);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newPassPanel
            // 
            this.newPassPanel.BackColor = System.Drawing.Color.Transparent;
            this.newPassPanel.Controls.Add(this.newPassOkButton);
            this.newPassPanel.Controls.Add(this.label3);
            this.newPassPanel.Controls.Add(this.newPassBox2);
            this.newPassPanel.Controls.Add(this.newPassBox1);
            this.newPassPanel.Location = new System.Drawing.Point(11, 91);
            this.newPassPanel.Name = "newPassPanel";
            this.newPassPanel.Size = new System.Drawing.Size(233, 125);
            this.newPassPanel.TabIndex = 5;
            this.newPassPanel.Visible = false;
            // 
            // newPassOkButton
            // 
            this.newPassOkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPassOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.newPassOkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPassOkButton.Location = new System.Drawing.Point(73, 81);
            this.newPassOkButton.Name = "newPassOkButton";
            this.newPassOkButton.Size = new System.Drawing.Size(75, 23);
            this.newPassOkButton.TabIndex = 8;
            this.newPassOkButton.Text = "Ok";
            this.newPassOkButton.UseVisualStyleBackColor = false;
            this.newPassOkButton.Click += new System.EventHandler(this.newPassOkButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(58, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // newPassBox2
            // 
            this.newPassBox2.BackColor = System.Drawing.Color.Black;
            this.newPassBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassBox2.Location = new System.Drawing.Point(46, 55);
            this.newPassBox2.Name = "newPassBox2";
            this.newPassBox2.Size = new System.Drawing.Size(129, 20);
            this.newPassBox2.TabIndex = 1;
            this.newPassBox2.TextChanged += new System.EventHandler(this.newPassBox2_TextChanged);
            // 
            // newPassBox1
            // 
            this.newPassBox1.BackColor = System.Drawing.Color.Black;
            this.newPassBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassBox1.Location = new System.Drawing.Point(46, 29);
            this.newPassBox1.Name = "newPassBox1";
            this.newPassBox1.Size = new System.Drawing.Size(129, 20);
            this.newPassBox1.TabIndex = 0;
            this.newPassBox1.TextChanged += new System.EventHandler(this.newPassBox1_TextChanged);
            // 
            // resetCodePanel
            // 
            this.resetCodePanel.BackColor = System.Drawing.Color.Transparent;
            this.resetCodePanel.Controls.Add(this.OkButton);
            this.resetCodePanel.Controls.Add(this.label4);
            this.resetCodePanel.Controls.Add(this.resetCodeBox);
            this.resetCodePanel.Location = new System.Drawing.Point(10, 92);
            this.resetCodePanel.Name = "resetCodePanel";
            this.resetCodePanel.Size = new System.Drawing.Size(203, 98);
            this.resetCodePanel.TabIndex = 6;
            this.resetCodePanel.Visible = false;
            // 
            // OkButton
            // 
            this.OkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OkButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OkButton.Location = new System.Drawing.Point(74, 61);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(64, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reset Code";
            // 
            // resetCodeBox
            // 
            this.resetCodeBox.BackColor = System.Drawing.Color.Black;
            this.resetCodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resetCodeBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetCodeBox.Location = new System.Drawing.Point(47, 35);
            this.resetCodeBox.Name = "resetCodeBox";
            this.resetCodeBox.Size = new System.Drawing.Size(129, 20);
            this.resetCodeBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 18);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(207, -2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(23, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(228, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PassResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(253, 221);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resetCodePanel);
            this.Controls.Add(this.newPassPanel);
            this.Controls.Add(this.emailPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PassReset";
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.newPassPanel.ResumeLayout(false);
            this.newPassPanel.PerformLayout();
            this.resetCodePanel.ResumeLayout(false);
            this.resetCodePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Panel emailPanel;
        private System.Windows.Forms.Panel newPassPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassBox2;
        private System.Windows.Forms.TextBox newPassBox1;
        private System.Windows.Forms.Panel resetCodePanel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resetCodeBox;
        private System.Windows.Forms.Button newPassOkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
    }
}