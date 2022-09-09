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
        Empleados empleadoslist = new Empleados();
        //corroborar si existe empleado en base al usuario y la contraseña
        public bool Existe(string nombre, string Contraseña)
        {
            bool existe = false;

            foreach (Empleado aux in empleadoslist.VerLista())
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
                foreach (Empleado aux in empleadoslist.VerLista())
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
        public bool Existeempleado(string Doc, string nombre)
        {
            bool existe = false;

            foreach (Empleado aux in empleadoslist.VerLista())
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

            foreach (Empleado aux in empleadoslist.VerLista())
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
        public bool Agregar(Empleado aux)
        {
            if (!Existesolodoc(aux.Num_Documento))
            {
                empleadoslist.Agregar(aux);
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
                empleadoslist.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
        //eliminar empleado corroborando si existe primero
        public bool Eliminar(Empleado aux)
        {
            if (Existesolodoc(aux.Num_Documento))
            {
                empleadoslist.Eliminar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Empleado> Listar()
        {
            return empleadoslist.VerLista();
        }

    }

}

