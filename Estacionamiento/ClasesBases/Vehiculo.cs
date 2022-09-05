using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public abstract class Vehiculo
    {
        public string telefono { get; set; }
        public string modelo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tiempo { get; set; }
        public double precio { get; set; }
        public string patente { get; set; }

    }

}

