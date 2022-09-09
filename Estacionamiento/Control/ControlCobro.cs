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
        ControlPlazas list;
        PrecioAuto precioAuto= new PrecioAuto();
        PrecioMoto precioMoto= new PrecioMoto();
        PrecioCamioneta precioCamioneta = new PrecioCamioneta();
        public ControlCobro (ControlPlazas listavehiculos)
        {
            list = listavehiculos;
        }
        //Deberia a partir de la patente devolver los datos del vehiculo para el formulario de cobro
        public Vehiculo TraerDatos(string Patente)
        {
            return list.VerVehiculo(Patente);
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
        //calcula el tiempo de estadia en meses
        public double ControlMes(DateTime MesEntrada, DateTime MesSalida, Vehiculo vehiculo)
        {
            int Meses = (MesSalida.Month - MesEntrada.Month);

            return CostoEstadiaMensual(Meses, vehiculo);
        }
        //devuleve el costo de la estadia mensual
        public double CostoEstadiaMensual(int Meses, Vehiculo aux)
        {
            if (aux is Moto)
            {
                return (precioMoto.mes * Meses);
            }
            else
                if (aux is Auto)
            {
                return (precioAuto.mes * Meses);
            }

            else

                if (aux is Camioneta)
            {
                return (precioCamioneta.mes * Meses);
            }

            return 0;
        }

        //Devuelve total a pagar del cliente
        public double CostoEstadia (int Horas, Vehiculo aux)
        {
            if (aux is Moto)
            {
                return (precioMoto.hora * Horas);
            }
            else 
                if (aux is Auto)
            {
                return (precioAuto.hora * Horas);
            }

            else

                if (aux is Camioneta)
            {
                return (precioCamioneta.hora * Horas);
            }
                
            return 0;
        }

    }
} 
                        
             
                        

                        