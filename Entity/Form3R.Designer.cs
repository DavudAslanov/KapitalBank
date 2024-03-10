namespace KapitalBank.Entity
{
    partial class Form3R
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(219, 198);
            label1.Name = "label1";
            label1.Size = new Size(287, 33);
            label1.TabIndex = 5;
            label1.Text = "LÜTFƏN GÖZLƏYİN ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 231);
            label2.Name = "label2";
            label2.Size = new Size(331, 33);
            label2.TabIndex = 6;
            label2.Text = "ƏMƏLİYYAT APARILIR...";
            // 
            // Form3R
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 529);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3R";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ƏMƏLİYYAT APARILIR...";
            Load += Form3R_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}