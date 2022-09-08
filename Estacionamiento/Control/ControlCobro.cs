using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;


namespace Estacionamiento.Control
{
    public class ControlCobro
    {
        Vehiculos VehiculosList;
        public void TraerDatos(string Patente)
        {
            foreach (Vehiculo aux in VehiculosList.VerLista())
            {
                if (aux.patente == Patente)
                {
                   
                }
            }
        }
    }
}