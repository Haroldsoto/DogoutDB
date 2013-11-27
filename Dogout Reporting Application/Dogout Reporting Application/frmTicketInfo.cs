using Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters;
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
    public partial class frmTicketInfo : Form
    {
        public int IdTicket;

        public frmTicketInfo(int idticketid)
        {
            InitializeComponent();
            IdTicket = idticketid;
        }

   
        private void frmTicketInfo_Load(object sender, EventArgs e)
        {
            
            this.TicketInfoTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.TicketInfo, IdTicket);
            this.reportViewer1.RefreshReport();
        }
    }
}
