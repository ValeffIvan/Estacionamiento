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

namespace Estacionamiento.Vistas
{
    public partial class FormContrasenia : Form
    {
        //inicializar el control
        ControlLogin control;
        public FormContrasenia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //corroborar respuesta para mostrar el cambiar contraseña
        private void btn_corroborarrespuesta_Click(object sender, EventArgs e)
        {
            if(control.corroborarpregunta(txt_respuestapregunta.Text))
            {
                panel_contranueva.Visible = true;
            }

        }
        //llama al control para cambiar la contraseña en caso de que el texto no este vacio
        //y en caso de que este vacio muestra un messagebox que diga respuesta incorrecta
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_contranueva.Text!="")
            {
                control.cambiarcontra(txt_contranueva.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }
        }
        //cierra el form
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
