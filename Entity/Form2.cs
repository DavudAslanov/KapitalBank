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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nagdlasdirma1 nagdlasdirma1 = new Nagdlasdirma1();
            nagdlasdirma1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QoyulanMebleg qoyulanMebleg = new QoyulanMebleg();
            qoyulanMebleg.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            QRkod qRkod = new QRkod();
            qRkod.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Xidmetler xidmetler = new Xidmetler();
            xidmetler.Show();
            this.Hide();
        }
    }
}
