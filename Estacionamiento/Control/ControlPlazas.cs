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
        double precio;
        Vehiculos VehiculosList = new Vehiculos();
        PrecioAuto precioauto;
        PrecioCamioneta precioCamioneta;
        PrecioMoto precioMoto;

        public ControlPlazas(PrecioAuto precioauto1, PrecioCamioneta precioCamioneta1, PrecioMoto precioMoto1)
        {
            precioauto = precioauto1;
            precioCamioneta= precioCamioneta1;
            precioMoto= precioMoto1;
        }
        // corrobora que los datos no esten vacios y devolver la carga realizada
        public bool Agregar(string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo, string tiempo, string caracteristicas, DateTime horaentrada)
        {
            if (telefono != "" && modelo != "" && nombre != "" && apellido != "" && patente != "" && caracteristicas != "")
            {
                
                switch (tipovehiculo)
                {
                    case "Auto":
                        {
                            if (tiempo == "Mes")
                            {
                                precio = precioauto.mes;
                            }
                            else
                            {
                                precio = precioauto.hora;
                            }
                            Auto aux = new Auto(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas, horaentrada);
                            VehiculosList.Add(aux);
                            break;
                        }
                    case "Camioneta":
                        {
                            if (tiempo == "Mes")
                            {
                                precio = precioCamioneta.mes;
                            }
                            else
                            {
                                precio = precioCamioneta.hora;
                            }
                            Camioneta aux = new Camioneta(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas, horaentrada);
                            VehiculosList.Add(aux);
                            break;
                        }
                    case "Moto":
                        {
                            if (tiempo == "Mes")
                            {
                                precio = precioMoto.mes;
                            }
                            else
                            {
                                precio = precioMoto.hora;
                            }
                            Moto aux = new Moto(telefono, modelo, nombre, apellido, tiempo, precio, patente, caracteristicas, horaentrada);
                            VehiculosList.Add(aux);
                            break;

                        }
                    default:
                        {
                            return true;
                        }
                }
                return false;
            }
            else
                return true;
        }

        //retirar vehiculo de la lista estacionamiento
        public bool Retirar (string patente)
        {
            foreach(var vehiculo in VehiculosList.VerLista())
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

        public Vehiculo VerVehiculo(string patente)
        {
            foreach (Vehiculo vehiculo in VehiculosList.VerLista())
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
