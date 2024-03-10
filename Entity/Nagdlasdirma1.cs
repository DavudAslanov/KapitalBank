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
    public partial class Nagdlasdirma1 : Form
    {
        public Nagdlasdirma1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cixaris cixaris = new Cixaris();
            cixaris.Show();
            this.Hide();
        }
    }
}
