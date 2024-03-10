using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapitalBank.Entity
{
    public partial class Form3R : Form
    {
        int i = 0;
        public Form3R()
        {
            InitializeComponent();
        }

        private void Form3R_Load(object sender, EventArgs e)
        {
           
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 50)
            {
                i++;

            }
            else
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                timer1.Stop();
            }
            
        }
    }
}
