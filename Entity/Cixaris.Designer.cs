namespace KapitalBank.Entity
{
    partial class Cixaris
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Red;
            textBox1.Location = new Point(324, 173);
            textBox1.MaxLength = 5;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 32);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Red;
            textBox2.Location = new Point(324, 117);
            textBox2.MaxLength = 5;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 32);
            textBox2.TabIndex = 1;
            textBox2.Text = "2000";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackgroundImage = Resource1.tam_mebleg2;
            button1.Location = new Point(513, 350);
            button1.Name = "button1";
            button1.Size = new Size(292, 75);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = Color.Maroon;
            textBox3.Location = new Point(62, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(670, 28);
            textBox3.TabIndex = 3;
            textBox3.Visible = false;
            // 
            // button2
            // 
            button2.BackgroundImage = Resource1.esas_menyu;
            button2.Location = new Point(513, 444);
            button2.Name = "button2";
            button2.Size = new Size(292, 64);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Cixaris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.png13;
            ClientSize = new Size(800, 529);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Cixaris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cixaris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
    }
}