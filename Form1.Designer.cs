namespace KapitalBank
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(338, 240);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = 'X';
            textBox1.Size = new Size(82, 30);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Firebrick;
            textBox2.Location = new Point(250, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(304, 31);
            textBox2.TabIndex = 1;
            textBox2.Text = "PiN KODUNUZ YALNIŞDIR";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveBorder;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(339, 241);
            textBox3.MaxLength = 4;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = 'X';
            textBox3.Size = new Size(84, 20);
            textBox3.TabIndex = 0;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.ForeColor = Color.Maroon;
            textBox4.Location = new Point(252, 163);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(302, 33);
            textBox4.TabIndex = 1;
            textBox4.Text = "PiN KODUNUZ YALNIŞDIR";
            textBox4.TextAlign = HorizontalAlignment.Center;
            textBox4.Visible = false;
            // 
            // Form1
            // 
            BackgroundImage = Resource1.png10;
            ClientSize = new Size(800, 529);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KAPITAL BANK";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}