using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Modelos;
using Estacionamiento.Vistas;

namespace Estacionamiento.Data
{
    public class Empleados
    {
        List<Empleado> Empleadoslist = new List<Empleado>();

        public void Agregar (Empleado aux)
        {
            Empleadoslist.Add(aux);
        }
        public List<Empleado> VerLista()
        {
            return Empleadoslist;
        }
        public void Eliminar (Empleado aux)
        {
            Empleadoslist.Remove(aux);
        }
    }
}