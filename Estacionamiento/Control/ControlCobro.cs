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

        //Deberia a partir de la patente devolver los datos del vehiculo para el formulario de cobro
        public void TraerDatos(string Patente)
        {
            VehiculosList.VerVehiculo(Patente);
        }

        //Devuelve el tiempo que el auto estuvo dentro
        public int ControlporHora(DateTime HoraEntrada, DateTime HoraSalida)
        {
            TimeSpan aux = (HoraSalida - HoraEntrada);
            int Horas = (int)aux.TotalHours;
            int Minutos = (int)aux.TotalMinutes;

            if (Minutos >= 20)
            {
                Horas++;
                return Horas;
            }
            else
            {
                return Horas;
            }
        }

        //Devuelve total a pagar del cliente
        public double CostoEstadia (int Hor)

    }
}