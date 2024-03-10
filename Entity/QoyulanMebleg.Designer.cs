namespace KapitalBank.Entity
{
    partial class QoyulanMebleg
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
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Location = new Point(37, 104);
            maskedTextBox1.Mask = "0000  0000  0000  0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(363, 20);
            maskedTextBox1.TabIndex = 0;
            // 
            // QoyulanMebleg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.png1;
            ClientSize = new Size(800, 529);
            Controls.Add(maskedTextBox1);
            Name = "QoyulanMebleg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QoyulanMebleg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
    }
}