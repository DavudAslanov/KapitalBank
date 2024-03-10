namespace KapitalBank.Entity
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Resource1.nagdlasdirma;
            button1.Location = new Point(1, 270);
            button1.Name = "button1";
            button1.Size = new Size(280, 71);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Resource1.karta_medaxil;
            button2.Location = new Point(1, 359);
            button2.Name = "button2";
            button2.Size = new Size(280, 68);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Resource1.xidmetler;
            button3.Location = new Point(1, 446);
            button3.Name = "button3";
            button3.Size = new Size(280, 71);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Resource1.Azerbaycan_dili;
            button4.Location = new Point(518, 270);
            button4.Name = "button4";
            button4.Size = new Size(285, 64);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = Resource1.Balans;
            button5.Location = new Point(518, 359);
            button5.Name = "button5";
            button5.Size = new Size(285, 64);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackgroundImage = Resource1.hesabdan_cixaris;
            button6.Location = new Point(518, 446);
            button6.Name = "button6";
            button6.Size = new Size(285, 64);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Resource1.qr_kod;
            button7.Location = new Point(1, 184);
            button7.Name = "button7";
            button7.Size = new Size(280, 80);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.png11;
            ClientSize = new Size(800, 529);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}