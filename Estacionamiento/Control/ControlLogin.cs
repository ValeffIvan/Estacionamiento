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
        Empleados EmpleadosList;
        public bool Existe(string Nom_Usuario, string Contraseña)
        {
            bool existe = false;

            foreach (Empleado aux in EmpleadosList.VerLista())
            {
                if (aux.Nom_Usuario == Nom_Usuario && aux.Contraseña == Contraseña)
                {
                    existe = true;
                    break;
                }
            }
            return existe;
        }

        public string Entrada(string Nom_Usuario, string Contraseña)
        {
            if (Existe(Nom_Usuario, Contraseña))
            {
                foreach (Empleado aux in EmpleadosList.VerLista())
                {
                    if (aux.Nom_Usuario == Nom_Usuario && aux.Administrador == true)
                    {
                        return "Administrador";
                    }
                    else
                    {
                        if (aux.Nom_Usuario == Nom_Usuario && aux.Administrador == false)
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

