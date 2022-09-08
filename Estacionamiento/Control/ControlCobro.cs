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
        //Instanciar clases
        Vehiculos VehiculosList;

        Auto auto;
        PrecioAuto precioAuto;
        
        Moto moto;
        PrecioMoto precioMoto;

        Camioneta camioneta;
        PrecioCamioneta precioCamioneta;

        //Deberia a partir de la patente devolver los datos del vehiculo para el formulario de cobro
        public void TraerDatos(string Patente)
        {
            VehiculosList.VerVehiculo(Patente);
        }

        //Devuelve el tiempo que el auto estuvo dentro
        public double ControlporHora(DateTime HoraEntrada, DateTime HoraSalida, Vehiculo vehiculo)
        {
            TimeSpan aux = (HoraSalida - HoraEntrada);
            int Horas = (int)aux.TotalHours;
            int Minutos = (int)aux.TotalMinutes;

            if (Minutos >= 20)
            {
                Horas++;
            }

            return CostoEstadia(Horas, vehiculo);

        }

        //Devuelve total a pagar del cliente
        public double CostoEstadia (int Horas, Vehiculo aux)
        {
            if (aux is Moto)
            {
                return (precioMoto.hora * Horas);
            }
            else if (aux is Auto)


            return 0;
        }

    }
} 
                        
             
                        return (precioAuto.hora * Horas);

                        return (precioCamioneta.hora * Horas);