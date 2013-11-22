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
    public partial class frmReportePagosPorFecha : Form
    {
        public string FechaDesde;
        public string FechaHasta;
        public string Estado;
        public frmReportePagosPorFecha(string fechadesde, string fechahasta, string estado)
        {
            InitializeComponent();
            FechaDesde = fechadesde;
            FechaHasta = fechahasta;
            Estado = estado;
        }

        private void frmReportePagosPorFecha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.DatosBancaTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.DatosBanca);
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.PagosEstadoPorFecha' table. You can move, or remove it, as needed.
            this.PagosEstadoPorFechaTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.PagosEstadoPorFecha, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaDesde, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaHasta, typeof(System.DateTime))))),Estado);

            this.reportViewer1.RefreshReport();
        }
    }
}
