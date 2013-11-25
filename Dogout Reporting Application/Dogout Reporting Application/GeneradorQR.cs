using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Dogout_Reporting_Application
{
    public partial class GeneradorQR : Form
    {
        public GeneradorQR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
            Bitmap barcodeBitmap;
            var result = writer.Write(textBox1.Text);
            barcodeBitmap = new Bitmap(result, new Size(256, 256));
            pictureBox1.Image = barcodeBitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            barcodeBitmap.Save("qr.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
