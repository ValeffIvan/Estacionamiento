using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class Camioneta:Vehiculo
    {
        public string Segmento { get; set; }
        //Segmento= Pick-up, Suv, Utilitario

        public Camioneta(string telefono, string modelo, string nombre, string apellido, string tiempo, double precio, string patente, string segmento, DateTime HoraEntrada)
        {
            this.telefono = telefono;
            this.modelo = modelo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tiempo = tiempo;
            this.precio = precio;
            this.patente = patente;
            this.Segmento = segmento;
            this.HoraEntrada = HoraEntrada;
        }

    }
}
