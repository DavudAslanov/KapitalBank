﻿namespace KapitalBank.Entity
{
    partial class Nagdlasdirma1
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Resource1.AZN;
            button1.Location = new Point(518, 269);
            button1.Name = "button1";
            button1.Size = new Size(285, 64);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Nagdlasdirma1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.png12;
            ClientSize = new Size(800, 529);
            Controls.Add(button1);
            Name = "Nagdlasdirma1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nagdlasdirma1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}