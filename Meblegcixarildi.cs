using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KapitalBank
{
    public partial class Meblegcixarildi : Form
    {
        int i = 0;
        public Meblegcixarildi()
        {
            InitializeComponent();
        }

        private void Meblegcixarildi_Load(object sender, EventArgs e)
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
                Form1 form = new Form1();
                form.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
