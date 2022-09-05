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
    public partial class FormCarga : Form
    {
        Button btn;
        ControlPlazas control;
        public FormCarga(Button btnx)
        {
            InitializeComponent();
            btn = btnx;
        }

        private void btn_aceptar_carga_Click(object sender, EventArgs e)
        {
            btn.BackColor = Color.Red;
            btn.Text = txt_patente.Text;
            if (rbtn_dia.Checked)
            {
                control.Agregar(mktxt_telefono.Text, txt_modelo.Text, txt_nombre.Text, txt_apellido.Text, txt_patente.Text, cb_tipovehiculo.Text, rbtn_dia.Text, txt_caract.Text);
                this.Close();
            }
            else if (rbtn_mes.Checked)
            {
                control.Agregar(mktxt_telefono.Text, txt_modelo.Text, txt_nombre.Text, txt_apellido.Text, txt_patente.Text, cb_tipovehiculo.Text, rbtn_mes.Text, txt_caract.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione tiempo de estadia");
            }
            
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
