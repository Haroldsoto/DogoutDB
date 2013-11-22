using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogout_Reporting_Application
{
    public class Jugada
    {
        public Jugada(int _id, string _descripcion)
    {
     
        Id = _id;
        Descripcion = _descripcion;
        
    }

        public Jugada()
        {
            // TODO: Complete member initialization
        }
        //comentario de prueba
    
    public int Id { get; set; }
    public string Descripcion { get; set; }
   
    }
}
