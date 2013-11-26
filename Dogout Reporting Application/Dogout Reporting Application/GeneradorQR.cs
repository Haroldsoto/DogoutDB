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
            GeneradorQR.GenerateQR(textBox1.Text);
            Bitmap bmp = new Bitmap("qr.bmp");
            pictureBox1.Image = bmp;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }
        public static void GenerateQR(string text)
        {
            IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
            Bitmap barcodeBitmap;
            var result = writer.Write("http://dogout.azurewebsites.net/Ticket/Details/" + text);
            barcodeBitmap = new Bitmap(result, new Size(256, 256));
            barcodeBitmap.Save("qr.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
        public static void GenerateQR(int numero)
        {
            IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
            Bitmap barcodeBitmap;
            var result = writer.Write("http://dogout.azurewebsites.net/Ticket/Details/" + numero.ToString());
            barcodeBitmap = new Bitmap(result, new Size(256, 256));
            barcodeBitmap.Save("qr.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
        

        
    }
}
