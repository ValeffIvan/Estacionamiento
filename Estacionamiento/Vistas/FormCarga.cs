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
        //inicializar un boton y el control del form
        Button btn;
        ControlPlazas control = new ControlPlazas();
        public FormCarga(Button btnx)
        {
            InitializeComponent();
            //traer el boton de otro form
            btn = btnx;
            lbl_fechaactual.Text = DateTime.Now.ToString();
        }
        //cambiar el color del boton y llamar al control para agregar el vehiculo
       private void btn_aceptar_carga_Click(object sender, EventArgs e)
        {
            btn.BackColor = Color.Red;
            btn.Text = txt_patente.Text;
            if (rbtn_dia.Checked)
            {
                if (!control.Agregar(mktxt_telefono.Text, txt_modelo.Text, txt_nombre.Text, txt_apellido.Text, txt_patente.Text, cb_tipovehiculo.Text, rbtn_dia.Text, txt_caract.Text,DateTime.Now))
                {
                    MessageBox.Show("Campo invalido");
                }else
                this.Close();
            }
            else if (rbtn_mes.Checked)
            {
                if (!control.Agregar(mktxt_telefono.Text, txt_modelo.Text, txt_nombre.Text, txt_apellido.Text, txt_patente.Text, cb_tipovehiculo.Text, rbtn_mes.Text, txt_caract.Text,DateTime.Now))
                {
                    MessageBox.Show("Campo invalido");
                }else
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione tiempo de estadia");
            }
            
        }
        //cerrar este form
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
