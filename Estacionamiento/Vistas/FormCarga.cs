using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamiento.Vistas
{
    public partial class FormCarga : Form
    {
        Button btn;
        public FormCarga(Button btnx)
        {
            InitializeComponent();
            btn = btnx;
        }

        private void btn_aceptar_carga_Click(object sender, EventArgs e)
        {
            btn.BackColor = Color.Red;
            btn.Text = txt_patente.Text;
            Close();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
