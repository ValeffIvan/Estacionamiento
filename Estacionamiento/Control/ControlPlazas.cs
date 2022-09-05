using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;

namespace Estacionamiento.Control
{
    public class ControlPlazas
    {
        Vehiculos vehiculos = new Vehiculos();
        // corrobora que los datos no esten vacios y devolver la carga realizada
        public bool Agregar (string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo, string tiempo, string caracteristicas)
        {
            if (telefono != "" || modelo != "" || nombre != "" || apellido != "" || patente != "" || caracteristicas !="")
            {
                return false;
            }
            else
            { 
                switch (tipovehiculo)
                {
                    case "Auto":
                        {
                            if (tiempo == "Mes")
                            {
                                double precio = PrecioAuto.mes;
                            }
                            else
                            {
                                double precio = PrecioAuto.hora;
                            }
                            Auto aux = new Auto(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas);
                            vehiculos.Add(aux);
                            break;
                        }
                    case "Camioneta":
                        {
                            if (tiempo == "Mes")
                            {
                                double precio = PrecioCamioneta.mes;
                            }
                            else
                            {
                                double precio = PrecioCamioneta.hora;
                            }
                            Camioneta aux = new Camioneta(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas);
                            vehiculos.Add(aux);
                            break;
                        }
                    case "Moto":
                        {
                            if (tiempo == "Mes")
                            {
                                double precio = PrecioMoto.mes;
                            }
                            else
                            {
                                double precio = PrecioMoto.hora;
                            }
                            Moto aux = new Moto(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas);
                            vehiculos.Add(aux);
                            break;

                        }
                    default:
                        {
                            return false;
                        }
                }
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
