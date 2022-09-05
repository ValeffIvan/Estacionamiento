using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Modelos;
using Estacionamiento.Vistas;

namespace Estacionamiento.Data
{
    public class Vehiculos
    {
        List<Vehiculo> Vehiculoslist = new List<Vehiculo>();

        // agregar vehiculos a la lista
        public void Add(Vehiculo aux)
        {
            if (!this.Exist(aux.patente))
            {
                Vehiculoslist.Add(aux);
            }
        }

        public bool Exist(string patente)
        {
            bool exist = false;

            foreach (Vehiculo aux in Vehiculoslist)
            {
                if (aux.patente == patente)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        public void Remove(Vehiculo aux)
        {
            Vehiculoslist.Remove(aux);
        }

        public List<Vehiculo> VerLista()
        {
            return Vehiculoslist;
        }

        public Vehiculo VerVehiculo(string patente)
        {
            foreach (Vehiculo vehiculo in Vehiculoslist)
            {
                if (vehiculo.patente == patente)
                {
                    return vehiculo;

                }
            }
            return null;
        }
    }
}
