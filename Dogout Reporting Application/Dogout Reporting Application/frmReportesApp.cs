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
    public partial class frmReportesApp : Form
    {
        public frmReportesApp()
        {
            InitializeComponent();
        }

        private void btnPartidosPorFecha_Click(object sender, EventArgs e)
        {
            frmMatchesPorFecha frmMatches = new frmMatchesPorFecha();
            frmMatches.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTicketsPorFecha frmTickets = new frmTicketsPorFecha();
            frmTickets.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPagosPorFecha frmPagos = new frmPagosPorFecha();
            frmPagos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGananciasPorEquipo frmGanancias = new frmGananciasPorEquipo();
            frmGanancias.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
