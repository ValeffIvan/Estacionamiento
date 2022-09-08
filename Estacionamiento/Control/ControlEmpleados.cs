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
        //inicializar lista
        Empleados EmpleadosList;
        //corroborar si existe empleado en base a doc y nombre de usuario
        public bool Existe(string Doc, string nombre)
        {
            bool existe = false;

            foreach (Empleado aux in EmpleadosList.VerLista())
            {
                if (aux.Nombre == nombre && aux.Num_Documento == Doc)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }
        //corroborar si existe empleado en base al documento
        public bool Existesolodoc(string Doc)
        {
            bool existe = false;

            foreach (Empleado aux in EmpleadosList.VerLista())
            {
                if (aux.Num_Documento == Doc)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }
        //agregar empleado trayendo la clase empleado y corroborar si existe o no
        public bool Agregar (Empleado aux)
        {
            if(!Existesolodoc(aux.Num_Documento))
            {
                EmpleadosList.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        //agregar empleado trayendo todos los datos y corroborar si existe ya o no
        public bool Agregar(string Nombre, string Apellido, string Num_Documento, 
                            string Nom_Usuario, string Contraseña, string Preg_Secreta, 
                            string Respuesta, bool Administrador)
        {
            if (!Existesolodoc(Num_Documento))
            {
                Empleado aux = new Empleado(Nombre, Apellido, Num_Documento,
                    Contraseña, Preg_Secreta, Respuesta, Administrador);
                EmpleadosList.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        //eliminar empleado corroborando si existe primero
        public bool Eliminar (Empleado aux)
        {
            if(Existesolodoc(aux.Num_Documento))
            {
                EmpleadosList.Eliminar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
