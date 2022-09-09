using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;
using Estacionamiento.Control;

namespace Estacionamiento.Control
{
    public class ControlLogin
    {
        //inicializar lista
        Empleados EmpleadosList = new Empleados();
        //corroborar si existe empleado en base al usuario y la contraseña
        public bool Existe(string nombre, string Contraseña)
        {
            bool existe = false;

            foreach (Empleado aux in EmpleadosList.VerLista())
            {
                if (aux.Nombre == nombre && aux.Contraseña == Contraseña)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public bool corroborarpregunta(string text)
        {

            return false;
        }

        //devolver el empleado 
        public string Entrada(string Nom_Usuario, string Contraseña)
        {
            if (Existe(Nom_Usuario, Contraseña))
            {
                foreach (Empleado aux in EmpleadosList.VerLista())
                {
                    if (aux.Nombre == Nom_Usuario && aux.Administrador == true)
                    {
                        return "Administrador";
                    }
                    else
                    {
                        if (aux.Nombre == Nom_Usuario && aux.Administrador == false)
                        {
                            return "Empleado";
                        }
                    }
                }
            }
            else
            {
                return "No Existe";
            }
            return null;
        }
        
    }

}

