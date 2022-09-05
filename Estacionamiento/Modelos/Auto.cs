using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class Auto:Vehiculo
    {
        public string Segmento { get; set; }
        //segmento= Sedan, Hatchback, Familiar, Deportivo
    }
}
