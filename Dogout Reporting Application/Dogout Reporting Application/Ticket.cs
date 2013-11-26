using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogout_Reporting_Application
{
    public class Ticket
    {

        public Ticket(int _id, DateTime _fechaticket, string _jugada, string _monto, int _ticketestado, int _lineaid, string _equipo, string _match  )
    {
        Id = _id;
        FechaTicket = _fechaticket;
            Jugada = _jugada;
            Monto = _monto;
      TicketEstado = _ticketestado;
            LineaId = _lineaid;
            Equipo = _equipo;
            Match = _match;

    }
        public int Id { get; set; }
        public DateTime FechaTicket { get; set; }
        public string Jugada { get; set; }
        public string Monto { get; set; }
        public int TicketEstado { get; set; }
        public int LineaId { get; set; }
        public string Equipo { get; set; }
        public string Match { get; set; }
    }
}
