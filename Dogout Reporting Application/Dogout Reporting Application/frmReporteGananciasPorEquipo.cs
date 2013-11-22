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
    public partial class frmReporteGananciasPorEquipo : Form
    {
        public string FechaDesde;
        public string FechaHasta;
        public int Equipo;
        public frmReporteGananciasPorEquipo(string fechadesde, string fechahasta, int equipo)
        {
            InitializeComponent();
            FechaDesde = fechadesde;
            FechaHasta = fechahasta;
            Equipo = equipo;
        }

        private void frmReporteGananciasPorEquipo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.DatosBancaTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.DatosBanca);
            // TODO: This line of code loads data into the 'CuboBusinessIntelligenceDataSet.GananciasPorEquipo' table. You can move, or remove it, as needed.
            this.GananciasPorEquipoTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.GananciasPorEquipo, Equipo, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaDesde, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaHasta, typeof(System.DateTime))))));

            this.reportViewer1.RefreshReport();
        }
    }
}
