using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters;

namespace Dogout_Reporting_Application
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void frmPagos_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBuscarTicket_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.TicketInfo' table. You can move, or remove it, as needed.
            this.TicketInfoTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.TicketInfo, int.Parse(txtIdTicket.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            CuboBusinessIntelligenceDataSetTableAdapters.SetPaidTicketTableAdapter adapter = new SetPaidTicketTableAdapter();
            CuboBusinessIntelligenceDataSet.SetPaidTicketDataTable dt = adapter.GetData(int.Parse(txtIdTicket.Text));
            this.TicketInfoTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.TicketInfo, int.Parse(txtIdTicket.Text));
            this.reportViewer1.RefreshReport();
            MessageBox.Show("El pago se ha efectuado y guaradado en la Base de Datos");
        }
    }
}
