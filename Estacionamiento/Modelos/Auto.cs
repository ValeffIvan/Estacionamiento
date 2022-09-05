using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class Auto : Vehiculo
    {


        public string Segmento { get; set; }
        //segmento= Sedan, Hatchback, Familiar, Deportivo


        public Auto(string telefono, string modelo, string nombre, string apellido, string tiempo, double precio, string patente, string segmento)
        {
            this.telefono = telefono;
            this.modelo = modelo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tiempo = tiempo;
            this.precio = precio;
            this.patente = patente;
            this.Segmento = segmento;
        }
    }
}
