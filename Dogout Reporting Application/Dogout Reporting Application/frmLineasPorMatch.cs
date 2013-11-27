﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dogout_Reporting_Application.CuboBusinessIntelligenceDataSetTableAdapters;

namespace Dogout_Reporting_Application
{
    public partial class frmLineasPorMatch : Form
    {
        public string Fecha;
        public DataGridViewRow selectedRow { get; set; }
        public frmLineasPorMatch()
        {
            InitializeComponent();
            dtpFechaMatch.Format = DateTimePickerFormat.Custom;
            dtpFechaMatch.CustomFormat = "MM/dd/yyyy";
            Fecha = DateTime.Now.ToString("MM/dd/yyyy");

            CuboBusinessIntelligenceDataSetTableAdapters.MatchesPorDiaTableAdapter adapter = new MatchesPorDiaTableAdapter();
            CuboBusinessIntelligenceDataSet.MatchesPorDiaDataTable dt = adapter.GetData(new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Fecha, typeof(System.DateTime))))));
            dgvMatches.DataSource = dt;
        }

        private void dtpFechaMatch_ValueChanged(object sender, EventArgs e)
        {
            Fecha = dtpFechaMatch.Text;
            CuboBusinessIntelligenceDataSetTableAdapters.MatchesPorDiaTableAdapter adapter = new MatchesPorDiaTableAdapter();
            CuboBusinessIntelligenceDataSet.MatchesPorDiaDataTable dt = adapter.GetData(new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(Fecha, typeof(System.DateTime))))));
            dgvMatches.DataSource = dt;
        }

        private void dgvMatches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dgvMatches.Rows[e.RowIndex];
            frmReporteLineasPorMatch frmReporteLineasPorMatch = new frmReporteLineasPorMatch(int.Parse(selectedRow.Cells["Código"].Value.ToString()));
            frmReporteLineasPorMatch.ShowDialog();
            //F;label2.Text = selectedRow.Cells["Código"].Value.ToString();
            /*
            frmCreateTicket frmTicket = new frmCreateTicket(selectedRow.Cells["Código"].Value.ToString(), selectedRow.Cells["Enfrentamiento"].Value.ToString());
            frmTicket.ShowDialog();
             * */
        }
    }
}