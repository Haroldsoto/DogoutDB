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
        public frmVentas()
        {
            InitializeComponent();
            getPayemnts();
        }




        public void getPayemnts()
        {
            Payments = new List<Payment>();
            //List<MyListBoxItem> AlertasAll = new List<MyListBoxItem>();
            List<string> PaymentsAll = new List<string>();
           CuboBusinessIntelligenceDataSetTableAdapters.GetPaymentsTableAdapter adapter = new GetPaymentsTableAdapter();
            CuboBusinessIntelligenceDataSet.GetPaymentsDataTable dt = adapter.GetData();
            foreach (var item in dt)
            {
                Payments.Add(new Payment(item.IdPayment, item.Monto.ToString(), item.Estado, item.TicketId));
                PaymentsAll.Add(item.IdPayment.ToString() + item.Monto.ToString() + item.Estado.ToString() + item.TicketId.ToString());
               // if (item.Estado == 0)
                 //   PaymentsAll.Add(new MyListBoxItem(Color.Red, item.IdPayment.ToString() + item.Monto.ToString()));
                //else if (item.Estado == 1)
                //    AlertasAll.Add(new MyListBoxItem(Color.Green, item.cDescripcion.ToString() + item.idParqueo.ToString()));
                //else if (item.Estado == 2)
                //    AlertasAll.Add(new MyListBoxItem(Color.Yellow, item.cDescripcion.ToString() + item.idParqueo.ToString()));
            }
            lbPayments.DataSource = PaymentsAll;
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



    }


}
