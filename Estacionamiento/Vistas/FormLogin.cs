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
    public partial class FormLogin : Form
    {
        ControlLogin control;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbl_olvidecontrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form contra = new Form();
            contra.Owner = this;
            contra.ShowDialog();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            /*string ingresar = control.Entrada(txt_usuario.Text,txt_contra.Text);
            if (ingresar == "admin")
            {
                FormAdministracion administracion = new FormAdministracion();
                administracion.Owner = this;
                administracion.Show();
                FormPrincipal principal = new FormPrincipal();
                principal.Owner = this;
                principal.Show();
                this.Hide();
            }else if (ingresar == "user")
            {

            }else
            {
                MessageBox.Show("No existe");
            }*/
            FormPrincipal princial = new FormPrincipal();   
            princial.Owner = this;
            princial.ShowDialog();
            this.Hide();
        }
    }
}
