using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogout_Reporting_Application
{
    public class Equipo
    {
        public Equipo(int _id, string _descripcion)
    {
        Id = _id;
        Descripcion = _descripcion;
    }
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }

}
