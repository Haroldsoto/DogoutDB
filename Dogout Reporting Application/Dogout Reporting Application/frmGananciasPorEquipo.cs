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
    public partial class frmGananciasPorEquipo : Form
    {
        public frmGananciasPorEquipo()
        {
            InitializeComponent();
            string[] Equipos = {"Orlando Magic","Indiana Pacers", "Los Angeles Clippers", "Los Angeles Lakers","Golden State Warriors", "Cleveland Cavaliers","Charlotte Bobcats","Chicago Bulls","Philadelphia 76ers","Detroit Pistons","Portland Trail Blazers"};
            cbEquipos.DataSource = Equipos;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "MM/dd/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "MM/dd/yyyy";
            int Equipoint = 0;
            if (cbEquipos.SelectedItem.ToString().Trim() == "Orlando Magic")
            {
                Equipoint = 66;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Indiana Pacers")
            {
                Equipoint = 56;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Los Angeles Clippers")
            {
                Equipoint = 63;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Los Angeles Lakers")
            {
                Equipoint = 65;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Golden State Warriors")
            {
                Equipoint = 61;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Cleveland Cavaliers")
            {
                Equipoint = 51;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Charlotte Bobcats")
            {
                Equipoint = 62;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Chicago Bulls")
            {
                Equipoint = 49;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Philadelphia 76ers")
            {
                Equipoint = 44;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Detroit Pistons")
            {
                Equipoint = 54;
            }
            if (cbEquipos.SelectedItem.ToString().Trim() == "Portland Trail Blazers")
            {
                Equipoint = 55;
            }

            frmReporteGananciasPorEquipo Formulario = new frmReporteGananciasPorEquipo(dtpFechaDesde.Text, dtpFechaHasta.Text, Equipoint);
            Formulario.ShowDialog();
        }
    }
}
