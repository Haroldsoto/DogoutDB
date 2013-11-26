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
    public partial class frmVentas : Form
    {
        public List<Payment> Payments;
        public List<Ticket> Tickets; 
        public frmVentas()
        {
            InitializeComponent();
            getPayemnts();
        }




        public void getPayemnts()
        {
            Payments = new List<Payment>();
            Tickets = new List<Ticket>();
            //List<MyListBoxItem> AlertasAll = new List<MyListBoxItem>();
            //List<string> PaymentsAll = new List<string>();
            List<MyListBoxItem> PaymentsAll = new List<MyListBoxItem>();
            List<MyListBoxItem> TicketsAll = new List<MyListBoxItem>();
           CuboBusinessIntelligenceDataSetTableAdapters.GetPaymentsTableAdapter adapter = new GetPaymentsTableAdapter();
            CuboBusinessIntelligenceDataSet.GetPaymentsDataTable dt = adapter.GetData();
            CuboBusinessIntelligenceDataSetTableAdapters.GetTicketsAllTableAdapter adaptertickets =  new GetTicketsAllTableAdapter();
            CuboBusinessIntelligenceDataSet.GetTicketsAllDataTable dttickets = adaptertickets.GetData();
            foreach (var item in dttickets)
            {
                Tickets.Add(new Ticket(item.Id, item.FechaTicket,item.DescripcionJugada, item.Monto.ToString(),item.TicketEstado,item.LineId, item.Name,item.ENFRENTAMIENTO));
                //PaymentsAll.Add(item.IdPayment.ToString() + item.Monto.ToString() + item.Estado.ToString() + item.TicketId.ToString());
                if (item.TicketEstado == 0)
                    TicketsAll.Add(new MyListBoxItem(Color.Green, "Código de la Venta: " + item.Id.ToString() + "  Monto de la apuesta:  RD$" + item.Monto.ToString() + " Jugada: " + item.DescripcionJugada + "  Equipo Apostado: " + item.Name + "  Partido: " + item.ENFRENTAMIENTO));
                else if (item.TicketEstado == 1)
                    TicketsAll.Add(new MyListBoxItem(Color.Blue, "Código de la Venta: " + item.Id.ToString() + "  Monto de la apuesta:  RD$" + item.Monto.ToString() + " Jugada: " + item.DescripcionJugada + "  Equipo Apostado: " + item.Name + "  Partido: " + item.ENFRENTAMIENTO));
               
            }
            lbPayments.DataSource = TicketsAll;
        }
        public class MyListBoxItem
        {
            public MyListBoxItem(Color c, string m)
            {
                ItemColor = c;
                Message = m;
            }
            public Color ItemColor { get; set; }
            public string Message { get; set; }
        }

        private void lbPayments_DrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBoxItem item = lbPayments.Items[e.Index] as MyListBoxItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Message, // The message linked to the item
                    lbPayments.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * lbPayments.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }



    }


}
