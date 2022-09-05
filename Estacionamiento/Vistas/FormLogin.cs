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
    public partial class FormLogin : Form
    {
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
    }
}
