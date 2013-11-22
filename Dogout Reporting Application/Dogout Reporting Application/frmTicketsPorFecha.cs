using System;
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
    public partial class frmTicketsPorFecha : Form
    {
        public List<Jugada> Jugadas { get; set; }
        public Jugada JugadaSelecc = new Jugada();
        public int IdJugada;
       
        public frmTicketsPorFecha()
        {
            InitializeComponent();
            string [] Estados = {"Todos los Tickets","Tickets Ganadores"};
            Jugadas = new List<Jugada>();

            CuboBusinessIntelligenceDataSetTableAdapters.JugadasTableAdapter Adapter = new JugadasTableAdapter();
            CuboBusinessIntelligenceDataSet.JugadasDataTable dt = Adapter.GetData();

            foreach (var item in dt)
            {
                Jugadas.Add(new Jugada(item.ID, item.Descripcion));
            }
            cbEstado.DataSource = Estados;
            cbJugadas.DataSource = Jugadas;
        }
         
        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            dtpFechaDesde.CustomFormat = "MM/dd/yyyy";
            dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            dtpFechaHasta.CustomFormat = "MM/dd/yyyy";
            int Estadoint;
            if (cbEstado.SelectedItem.ToString().Trim() == "Todos los Tickets")
            {
                Estadoint = 0;
            }
            else
            {
                Estadoint = 1;
            }
            frmReporteTicketsPorFecha Formulario = new frmReporteTicketsPorFecha(dtpFechaDesde.Text, dtpFechaHasta.Text, Estadoint, IdJugada );
            Formulario.ShowDialog();
        }

        private void cbJugadas_SelectedValueChanged(object sender, EventArgs e)
        {
            Jugada objeto = (Jugada) cbJugadas.SelectedItem;
            IdJugada = objeto.Id;
        }
    }
}
