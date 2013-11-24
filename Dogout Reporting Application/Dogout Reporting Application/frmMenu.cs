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
    public partial class opReportes : Form
    {
        public opReportes()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
           ucReportes.formToOpen = new frmReportesApp();
           ucOpcionesMenu2.formToOpen = new GeneradorQR();
            ucTickets.formToOpen = new frmGenerarTicket();
        }

        private void ucReportes_Load(object sender, EventArgs e)
        {

        }

        private void ucReportes_Click(object sender, EventArgs e)
        {
            ucReportes.formToOpen = new frmReportesApp();
        }

        private void ucOpcionesMenu2_Load(object sender, EventArgs e)
        {
            
        }
        
    


        
    }
}
