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

namespace Estacionamiento
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clickPlaza(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor != Color.Red)
            {
                FormCarga carga = new FormCarga(button);
                carga.Owner = this;
                carga.ShowDialog();
            }
            else
            {
                FormCobro cobro = new FormCobro();
                cobro.Owner = this;
                cobro.ShowDialog();
            }
        }
    }
}
