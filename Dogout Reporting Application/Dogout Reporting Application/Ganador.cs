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
    public partial class Ganador : Form
    {
        public decimal MontoGanador;
        public Ganador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ganador_Load(object sender, EventArgs e)
        {
         
        }

        private void btnBuscarTicket(object sender, EventArgs e)
        {
            this.TicketInfoTableAdapter.Fill(this.CuboBusinessIntelligenceDataSet.TicketInfo, int.Parse(textBox1.Text));
            this.reportViewer1.RefreshReport();
        }

        private void btnSetWinner(object sender, EventArgs e)
        {
            MontoGanador = 7500;
            CuboBusinessIntelligenceDataSetTableAdapters.SetWinnerTableAdapter adapter = new CuboBusinessIntelligenceDataSetTableAdapters.SetWinnerTableAdapter();
            CuboBusinessIntelligenceDataSet.SetWinnerDataTable dt = adapter.GetData(int.Parse(textBox1.Text),MontoGanador);
            MessageBox.Show("Exitoso!");
        }
    }
}
