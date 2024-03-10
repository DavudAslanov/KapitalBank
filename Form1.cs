using KapitalBank.Entity;

namespace KapitalBank
{
    public partial class Form1 : Form
    {

        int i = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            string pass = "2003";


            if (i != 20)
            {
                i++;
            }
            else
            {
                if (textBox3.Text == pass)
                {
                    Form3R form3 = new Form3R();
                    form3.Show();
                    this.Hide();
                    timer1.Stop();
                }
                else
                {

                    if (textBox3.Text != string.Empty)
                    {
                        textBox4.Visible = true;
                    }
                    else
                    {
                        textBox4.Visible = false;
                    }


                }




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
