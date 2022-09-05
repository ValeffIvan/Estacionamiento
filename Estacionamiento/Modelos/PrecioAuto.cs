using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class PrecioAuto : Aranceles
    {
        public PrecioAuto()
        {
            this.hora = 100;
            
            this.dia = 1000;

            this.mes = 10000;
        }
    }
}
