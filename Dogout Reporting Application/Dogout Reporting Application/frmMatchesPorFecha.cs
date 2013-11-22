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
    public partial class frmMatchesPorFecha : Form
    {
        public string fechadesde;
        public string fechahasta;
        public frmMatchesPorFecha()
        {
            InitializeComponent();
        }
        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "MM/dd/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "MM/dd/yyyy";
            frmReporteMatchesPorFecha Formulario = new frmReporteMatchesPorFecha(dtpFechaDesde.Text, dtpFechaHasta.Text);
            Formulario.ShowDialog();
        }

        private void frmMatchesPorFecha_Load(object sender, EventArgs e)
        {

        }
        
    }
}
