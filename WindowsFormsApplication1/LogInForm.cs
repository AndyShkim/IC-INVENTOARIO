using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            //server=localhost;user id=root;database=inventario_ic
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (wwidbox.Text == "11878407" && clavebox.Text == "nakisha")
            {
                WindowsFormsApplication1.Fm_main fm = new WindowsFormsApplication1.Fm_main();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Clave Incorrecta");
            }
        }
    }
}
