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
    public partial class frmPagosPorFecha : Form
    {
        public string fechadesde;
        public string fechahasta;
        public frmPagosPorFecha()
        {
            InitializeComponent();
            string[] Estados = { "Pendientes", "Pagados" };
            cbEstado.DataSource = Estados;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "MM/dd/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "MM/dd/yyyy";
            string Estado;
            if (cbEstado.SelectedItem.ToString().Trim() == "Pagados")
            {
                Estado = "1";
            }
            else
            {
                Estado = "0";
            }
            frmReportePagosPorFecha Formulario = new frmReportePagosPorFecha(dtpFechaDesde.Text, dtpFechaHasta.Text, Estado);
            Formulario.ShowDialog();
        }
    }
}
