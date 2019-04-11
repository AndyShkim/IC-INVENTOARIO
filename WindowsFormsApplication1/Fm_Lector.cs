using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Fm_Lector : Form
    {
        FilterInfoCollection deviceCapture;
        VideoCaptureDevice finalFrame;
        bool frame_exist = false;
        public Fm_Lector()
        {
            InitializeComponent();
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            finalFrame = new VideoCaptureDevice(deviceCapture[devices_box.SelectedIndex].MonikerString);
            finalFrame.Start();
            finalFrame.NewFrame += finalFrame_renew;
            Thread process_qr_thread = new Thread(new ThreadStart(analyze_qr));
            process_qr_thread.Start();
        }

        private void finalFrame_renew(object sender, NewFrameEventArgs eventArgs) {
            picture_cam.Image = (Bitmap)eventArgs.Frame.Clone();
            frame_exist = true;
        }

        private void analyze_qr() {
            string texto = null;
            while(texto == null) {
                BarcodeReader br = new BarcodeReader();
                try
                {
                    texto = br.Decode((Bitmap)picture_cam.Image.Clone()).ToString();
                    textBox.Text = texto;
                }
                catch {
                    //MessageBox.Show("No se ha generado ningun QR nuevo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Fm_Lector_Load(object sender, EventArgs e)
        {
            deviceCapture = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo cam in deviceCapture){
                devices_box.Items.Add(cam.Name);
            }
            devices_box.SelectedIndex = 0;
            finalFrame = new VideoCaptureDevice();
        }
    }
}
