using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class PrecioCamioneta:Aranceles
    {
        public PrecioCamioneta(double mes, double hora) : base(mes, hora)
        {
            this.hora = 100;

            this.mes = 10000;
        }
    }
}

