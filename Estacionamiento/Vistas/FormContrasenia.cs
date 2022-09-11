using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Control;
using Estacionamiento.Data;

namespace Estacionamiento.Vistas
{
    public partial class FormContrasenia : Form
    {
        //inicializar el control
        ControlLogin control;
        public FormContrasenia(ControlLogin controltodo)
        { 
            InitializeComponent();
            control = controltodo;
            panel_contranueva.Visible = false;
            panel_pregunta.Visible = false;
            cb_nombre.DataSource = control.Listar();
        }

        //corroborar respuesta para mostrar el cambiar contraseña
        private void btn_corroborarrespuesta_Click(object sender, EventArgs e)
        {
            if(control.corroborarpregunta(cb_nombre.Text,txt_respuestapregunta.Text))
            {
                panel_contranueva.Visible = true;
                cb_nombre.Enabled = false;
            }

        }
        //llama al control para cambiar la contraseña en caso de que el texto no este vacio
        //y en caso de que este vacio muestra un messagebox que diga respuesta incorrecta
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cb_nombre.Text != "")
            {
                if (txt_contranueva.Text != "")
                {
                    if (control.cambiarcontra(cb_nombre.Text, txt_contranueva.Text))
                    {
                        control.cambiarcontra(cb_nombre.Text, txt_contranueva.Text);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Respuesta incorrecta");
                }
            }else
            {
                MessageBox.Show("Seleccione Usuario");
            }
        }
        //cierra el form
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_nombre_DropDown(object sender, EventArgs e)
        {
            cb_nombre.DataSource = null;
            cb_nombre.DataSource = control.Listar();
        }
    }
}
