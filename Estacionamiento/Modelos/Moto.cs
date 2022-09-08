using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class Moto:Vehiculo
    {
        public string Cilindrada { get; set; }

        public Moto(string telefono, string modelo, string nombre, string apellido, string tiempo, double precio, string patente, string cilindrada, DateTime HoraEntrada)
        {
            this.telefono = telefono;
            this.modelo = modelo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tiempo = tiempo;
            this.precio = precio;
            this.patente = patente;
            this.Cilindrada = cilindrada;
            this.HoraEntrada = HoraEntrada;
        }

    }
}
