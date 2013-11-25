using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogout_Reporting_Application
{
    public class Payment
    {
        public string Monto { get; set; }
        public int idPayment { get; set; }
        public int idTicket { get; set; }
        public int Estado { get; set; }


        public Payment(int id, string monto, int estado, int ticketid)
        {
            Monto = monto;
            idPayment = id;
            idTicket = ticketid;
            Estado = estado;

        }
    }
}
