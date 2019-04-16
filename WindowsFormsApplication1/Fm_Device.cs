using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fm_Device : Form
    {
        public Fm_Device()
        {
         String idQr;
         InitializeComponent();
        
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fm_Device_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            textqr.Text = idQr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Qr_Code_Generator.GeneratorForm form = new Qr_Code_Generator.GeneratorForm();
            form.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_main fm = new WindowsFormsApplication1.Fm_main();
            fm.Show();
            this.Hide();
        }
    }
}
