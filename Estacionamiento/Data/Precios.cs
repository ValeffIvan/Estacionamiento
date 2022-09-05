using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Modelos;

namespace Estacionamiento.Data
{
    public class Precios
    {
        public PrecioAuto auto { get; set; }
        public PrecioCamioneta camioneta { get; set; }
        public PrecioMoto moto { get; set; }
    }
}
