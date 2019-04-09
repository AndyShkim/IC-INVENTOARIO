using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qr_Code_Generator
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgQr.Image = brcode.Draw(txtQr.Text, 50);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratorForm frm = new GeneratorForm();
            frm.Show();
            this.Hide();
        }
    }
}
