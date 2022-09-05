using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;


namespace Estacionamiento.Control
{
    public class ControlEmpleados
    {
        Empleados EmpleadosList;
        public bool Existe(string Doc, string Nom_Usuario)
        {
            bool existe = false;

            foreach (Empleado aux in EmpleadosList.VerLista())
            {
                if (aux.Nom_Usuario == Nom_Usuario && aux.Num_Documento == Doc)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public bool Agregar (Empleado aux)
        {
            if(!Existe(aux.Num_Documento))
            {
                EmpleadosList.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Agregar(string Nombre, string Apellido, string Num_Documento, 
                            string Nom_Usuario, string Contraseña, string Preg_Secreta, string Respuesta, bool Administrador)
        {
            if (!Existe(Num_Documento))
            {
                Empleado aux = new Empleado(Nombre, Apellido, Num_Documento, Nom_Usuario,
                    Contraseña, Preg_Secreta, Respuesta, Administrador);
                EmpleadosList.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Eliminar (Empleado aux)
        {
            if(Existe(aux.Num_Documento))
            {
                EmpleadosList.Eliminar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        /*public bool Eliminar(string Nombre, string Apellido, string Num_Documento,
                            string Nom_Usuario, string Contraseña, string Preg_Secreta, string Respuesta, bool Administrador)
        {
            if (Existe(Num_Documento))
            {
                Empleado aux = new Empleado(Nombre, Apellido, Num_Documento, Nom_Usuario,
                    Contraseña, Preg_Secreta, Respuesta, Administrador);
                EmpleadosList.Eliminar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
}
