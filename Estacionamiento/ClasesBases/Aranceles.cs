using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public abstract class Aranceles
    {
        public double dia { get; set; }

        public double mes { get; set; }

        public double hora { get; set; }

        public Aranceles  (double dia, double mes, double hora)
        {
            this.dia = dia;
            this.mes = mes;
            this.hora = hora;
        }
    }
}
