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
            ucOpcionesMenu2.formToOpen = new frmReportesApp();
           ucOpcionesMenu1.formToOpen = new frmGenerarTicket();
           ucOpcionesMenu3.formToOpen = new frmPagos();
             ucOpcionesMenu4.formToOpen = new frmVentas();
        }

        private void ucReportes_Load(object sender, EventArgs e)
        {

        }

        private void ucReportes_Click(object sender, EventArgs e)
        {
            
        }

       
        
    


        
    }
}
