using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogout_Reporting_Application
{
    public partial class frmTicketImpreso : Form
    {
        public frmTicketImpreso()
        {
            InitializeComponent();
            reportViewer1.LocalReport.EnableExternalImages = true;
            

        }

        private void frmTicketImpreso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.LastTicket' table. You can move, or remove it, as needed.
            this.LastTicketTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.LastTicket);
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.DatosBancaTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.DatosBanca);



            string path = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);

            reportViewer1.LocalReport.EnableExternalImages = true;
            List<ReportParameter> param1 = new List<ReportParameter>();
            param1.Add(new ReportParameter("Path",path+"/qr.bmp"));
            reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.RefreshReport();
        }
    }
}
