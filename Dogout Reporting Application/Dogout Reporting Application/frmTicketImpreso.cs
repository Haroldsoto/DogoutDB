using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void frmTicketImpreso_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.LastTicket' table. You can move, or remove it, as needed.
            this.LastTicketTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.LastTicket);
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.DatosBancaTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.DatosBanca);

            this.reportViewer1.RefreshReport();
        }
    }
}
