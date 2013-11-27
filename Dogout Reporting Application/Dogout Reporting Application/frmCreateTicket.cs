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
    public partial class frmCreateTicket : Form
    {
        public List<Jugada> Jugadas { get; set; }
        public List<string> Equipos { get; set; }
        public string Home;
        public string Away;
        public string Match;
        public int IdJugada;
        public int One, Seven, Eight;
        public frmCreateTicket(string matchid, string enfrentamiento,int one,int seven,int eight)
        {
            InitializeComponent();
            One = one;
            Seven = seven;
            Eight = eight;
            Match = matchid;
            lblEnfrentamiento.Text = enfrentamiento;
            CuboBusinessIntelligenceDataSetTableAdapters.JugadasTableAdapter Adapter = new JugadasTableAdapter();
            CuboBusinessIntelligenceDataSet.JugadasDataTable dt = Adapter.GetData();
            CuboBusinessIntelligenceDataSetTableAdapters.TeamsMatchTableAdapter Adapter1 = new TeamsMatchTableAdapter();
            CuboBusinessIntelligenceDataSet.TeamsMatchDataTable dt1 = Adapter1.GetData(int.Parse(matchid));
            Jugadas = new List<Jugada>();
            Equipos = new List<string>();
            Home = (from DataRow dr in dt1.Rows
                      select (string)dr["Home"]).FirstOrDefault();
            Away = (from DataRow dr in dt1.Rows
                           select (string)dr["Away"]).FirstOrDefault();
            Equipos.Add(Home);
            Equipos.Add(Away); 
            Jugadas = dt.Select(item => new Jugada(item.ID, item.Descripcion)).ToList();
            cbJugadas.DataSource = Jugadas;
            cbEquipo.DataSource = Equipos;
        }
        public static int rnd(int desde, int hasta)
        {
            Random rl = new Random();
            return rl.Next(desde, (hasta + 1));
        }
        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrearTicket_Click(object sender, EventArgs e)
        {
            CuboBusinessIntelligenceDataSetTableAdapters.TeamsMatchTableAdapter Adapter1 = new TeamsMatchTableAdapter();
            CuboBusinessIntelligenceDataSet.TeamsMatchDataTable dt1 = Adapter1.GetData(int.Parse(Match));
            CuboBusinessIntelligenceDataSetTableAdapters.GetLastIdTableAdapter AdapterId = new GetLastIdTableAdapter();
            CuboBusinessIntelligenceDataSet.GetLastIdDataTable dt2 = AdapterId.GetData();
            int TeamId = 0;
            int LineId;
            if(Match == "1")
            {
                LineId = Dogout_Reporting_Application.opReportes.one;
            }
            else if (Match == "7")
            {
                LineId = Dogout_Reporting_Application.opReportes.seven;
            }
            else if (Match == "8")
            {
                LineId = Dogout_Reporting_Application.opReportes.eight;
            }
            else
                 LineId = 100;
            Jugada objeto = (Jugada)cbJugadas.SelectedItem;
            IdJugada = objeto.Id;
            if (cbEquipo.SelectedItem.ToString() == Home)
            {
               
                //label1.Text = (from DataRow dr in dt1.Rows
                                      //select (int)dr["IdHome"]).FirstOrDefault().ToString();
            TeamId = (from DataRow dr in dt1.Rows
                                      select (int)dr["IdHome"]).FirstOrDefault();
            }

            else if (cbEquipo.SelectedItem.ToString() == Away)
            {
               
               // label1.Text = (from DataRow dr in dt1.Rows
                 //                     select (int)dr["IdAway"]).FirstOrDefault().ToString();
            TeamId = (from DataRow dr in dt1.Rows
                                      select (int)dr["IdAway"]).FirstOrDefault();
            }
            int LastId = (from DataRow dr in dt2.Rows
                      select (int)dr["Codigo"]).FirstOrDefault() + 1;
            GeneradorQR.GenerateQR(LastId.ToString());
            CuboBusinessIntelligenceDataSetTableAdapters.SetTicketTableAdapter Adapter = new SetTicketTableAdapter();
            CuboBusinessIntelligenceDataSet.SetTicketDataTable dt = Adapter.GetData(IdJugada,decimal.Parse(tbMonto.Text),int.Parse(Match),TeamId,LineId,DateTime.Now);
            frmTicketImpreso frmTicketImpreso = new frmTicketImpreso();
            frmTicketImpreso.ShowDialog();
        }

        private void cbJugadas_SelectedValueChanged(object sender, EventArgs e)
        {
            Jugada objeto = (Jugada)cbJugadas.SelectedItem;
            IdJugada = objeto.Id;
        }

        private void frmCreateTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
