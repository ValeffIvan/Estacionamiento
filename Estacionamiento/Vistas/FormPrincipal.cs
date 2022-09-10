using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estacionamiento.Vistas;
using Estacionamiento.Control;
using Estacionamiento.Modelos;

namespace Estacionamiento
{
    public partial class FormPrincipal : Form
    {
        ControlPlazas listaprincipal;
        public FormPrincipal(string principalName, ControlPlazas vehi)
        {
            InitializeComponent();
            listaprincipal = vehi;
            lbl_nombreusuario.Text = principalName;
        }
        //abrir el form de carga o de cobro en base al color del boton
        private void clickPlaza(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.Red)
            {
                FormCarga carga = new FormCarga(button,listaprincipal);
                carga.Owner = this;
                carga.ShowDialog();
            }
            else
            {
                FormCobro cobro = new FormCobro(button.Text,listaprincipal);
                cobro.Owner = this;
                cobro.ShowDialog();
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
            this.Close();
        }
        /*
//override para cerrar el login al cerrar este programa
protected override void OnFormClosing(FormClosingEventArgs e)
{
   // base.OnFormClosing(e);

   //FormLogin log = (FormLogin)this.Owner;
   //log.Close();
   this.Owner.Visible = true;
   this.Close();
}
*/
    }
}
