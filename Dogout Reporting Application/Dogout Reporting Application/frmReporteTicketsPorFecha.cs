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
    public partial class frmReporteTicketsPorFecha : Form
    {
        public string FechaDesde;
        public string FechaHasta;
        public int Estado;
        public int Jugada;
        public frmReporteTicketsPorFecha(string fechadesde, string fechahasta, int estado, int jugada)
        {
            InitializeComponent();
            FechaDesde = fechadesde;
            FechaHasta = fechahasta;
            Estado = estado;
            Jugada = jugada;
        }

        private void frmReporteTicketsPorFecha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cuboBusinessIntelligenceDataSet.TicketsPorFecha' table. You can move, or remove it, as needed.
            this.ticketsPorFechaTableAdapter.Fill(this.cuboBusinessIntelligenceDataSet.TicketsPorFecha,Estado, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaDesde, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaHasta, typeof(System.DateTime))))),Jugada);
            // TODO: This line of code loads data into the 'cuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.datosBancaTableAdapter.Fill(this.cuboBusinessIntelligenceDataSet.DatosBanca);
           this.reportViewer1.RefreshReport();
        }
    }
}
