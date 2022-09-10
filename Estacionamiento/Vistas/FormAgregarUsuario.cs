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
    public partial class FormAgregarUsuario : Form
    {
        ControlLogin list;
        public FormAgregarUsuario(ControlLogin userlist)
        {
            InitializeComponent();
            list = userlist;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado(txt_nombre.Text, txt_apellido.Text, npd_documento.Value.ToString(), txt_contraseña.Text, cb_pregunta.Text, txt_respuesta.Text, rbutton_admin.Checked);
            list.Agregar(empleado);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
