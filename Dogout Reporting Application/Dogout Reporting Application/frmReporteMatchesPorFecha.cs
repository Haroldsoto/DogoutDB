//------------------------------------------------------------------
// <copyright company="Microsoft">
//     Copyright (c) Microsoft.  All rights reserved.
// </copyright>
//------------------------------------------------------------------
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
    public partial class frmReporteMatchesPorFecha : Form
    {
        public string FechaDesde;
        public string FechaHasta;
        public frmReporteMatchesPorFecha(string fechadesde, string fechahasta)
        {
            InitializeComponent();
            FechaDesde = fechadesde;
            FechaHasta = fechahasta;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'cuboBusinessIntelligenceDataSet.DatosBanca' table. You can move, or remove it, as needed.
            this.datosBancaTableAdapter.Fill(this.cuboBusinessIntelligenceDataSet.DatosBanca);
            this.matchesPorFechaTableAdapter.Fill(this.cuboBusinessIntelligenceDataSet.MatchesPorFecha, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaDesde, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(FechaHasta, typeof(System.DateTime))))));
            this.reportViewer1.RefreshReport();
            
        }

       
    }
}