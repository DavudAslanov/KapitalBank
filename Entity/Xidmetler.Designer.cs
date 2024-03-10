namespace KapitalBank.Entity
{
    partial class Xidmetler
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.XIDMETLER1;
            pictureBox1.Location = new Point(126, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = Color.White;
            button1.Location = new Point(563, 185);
            button1.Name = "button1";
            button1.Size = new Size(236, 61);
            button1.TabIndex = 1;
            button1.Text = "ENGLISH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.ForeColor = Color.White;
            button2.Location = new Point(563, 267);
            button2.Name = "button2";
            button2.Size = new Size(236, 61);
            button2.TabIndex = 2;
            button2.Text = "Русский";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Maroon;
            button3.ForeColor = Color.White;
            button3.Location = new Point(563, 346);
            button3.Name = "button3";
            button3.Size = new Size(236, 61);
            button3.TabIndex = 3;
            button3.Text = "Ləğv Et";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Xidmetler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Xidmetler";
            Text = "Xidmetler";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}