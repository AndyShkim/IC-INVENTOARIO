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
    public partial class Fm_main : Form
    {
        public Fm_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_Lector fm = new WindowsFormsApplication1.Fm_Lector();
            fm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_Lector fm = new WindowsFormsApplication1.Fm_Lector();
            fm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_datos fm = new WindowsFormsApplication1.Fm_datos();
            fm.Show();
            this.Hide();
        }

        private void inventarioAnadir_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_Device fm = new WindowsFormsApplication1.Fm_Device();
            fm.Show();
            this.Hide();
        }

        private void inventarioActualizar_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Fm_Device fm = new WindowsFormsApplication1.Fm_Device();
            fm.Show();
            this.Hide();
        }
    }
}
