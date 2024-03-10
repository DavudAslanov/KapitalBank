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
    public partial class Cixaris : Form
    {
        public Cixaris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;

            int c = Convert.ToInt32(b);
            int d = Convert.ToInt32(a);
            if (d >= c)
            {
                textBox3.Visible = true;
                textBox3.Text = "BALANSINIZDA KİFAYƏT QƏDƏR VƏSAİT YOXDUR";
            }
            else
            {
                Meblegcixarildi meblegcixarildi = new Meblegcixarildi();
                meblegcixarildi.Show();
                this.Hide();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
