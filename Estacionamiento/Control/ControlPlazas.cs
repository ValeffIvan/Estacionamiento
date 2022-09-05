using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;

namespace Estacionamiento.Vistas
{
    public class ControlPlazas
    {
        Vehiculos vehiculos = new Vehiculos();
        // corrobora que los datos no esten vacios y devolver la carga realizada
        public bool Agregar (string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo)
        {
            if (telefono != "" || modelo != "" || nombre != "" || apellido != "" || patente != "" || tipovehiculo !="")
            {
                return false;
            }
            else
            { 
                Vehiculo aux = new Vehiculo(telefono, modelo, nombre, apellido, patente, tipovehiculo);
                vehiculos.Add(aux);

                return true;
            }
        }

        //retirar vehiculo de la lista estacionamiento
        public bool Retirar (string patente)
        {
            foreach(var vehiculo in vehiculos.VerLista())
            {
                if (vehiculo.patente == patente)
                {
                    //vehiculos.Remove(aux);
                    break;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
