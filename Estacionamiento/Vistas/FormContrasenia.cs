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
        ControlLogin control;
        public FormContrasenia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_corroborarrespuesta_Click(object sender, EventArgs e)
        {
            if(control.corroborarpregunta(txt_respuestapregunta.Text))
            {
                panel_contranueva.Visible = true;
            }

        }

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

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
