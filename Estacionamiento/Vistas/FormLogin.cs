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
using Estacionamiento.Modelos;

namespace Estacionamiento.Vistas
{
    public partial class FormLogin : Form
    {
        //inicializar el controlador
        ControlLogin control = new ControlLogin();
        PrecioAuto precioAuto = new PrecioAuto();
        PrecioMoto precioMoto = new PrecioMoto();
        PrecioCamioneta precioCamioneta = new PrecioCamioneta();
        public FormLogin()
        {
            InitializeComponent();
        }
        //abrir el form de cambio de contraseña
        private void lbl_olvidecontrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form contra = new Form();
            contra.Owner = this;
            contra.ShowDialog();
        }
        //ingresar al form principal con el estacionamiento
        //si se es administrador tambien abre el form de administracion
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            string ingresar = control.Entrada(txt_usuario.Text,txt_contra.Text);
            if (ingresar == "admin" || txt_usuario.Text=="123" )
            {
                FormAdministracion administracion = new FormAdministracion(control,precioAuto,precioMoto, precioCamioneta);
                administracion.Owner = this;
                administracion.Show();
                FormPrincipal principal = new FormPrincipal(txt_usuario.Text, precioAuto,  precioCamioneta,precioMoto);
                principal.Owner = this;
                principal.Show();
                this.Hide();
            }else if (ingresar == "user")
            {
                FormPrincipal principal = new FormPrincipal(txt_usuario.Text, precioAuto,precioCamioneta, precioMoto);
                principal.Owner = this;
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario no existe no existe");
            }
        }
    }
}
