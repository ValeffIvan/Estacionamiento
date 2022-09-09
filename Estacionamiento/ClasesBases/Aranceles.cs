using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public abstract class Aranceles
    { 

        public double mes { get; set; }

        public double hora { get; set; }

        public Aranceles ()
        { }
        public Aranceles  (int mes, int hora)
        {
            this.mes = mes;
            this.hora = hora;
        }
    }
}
