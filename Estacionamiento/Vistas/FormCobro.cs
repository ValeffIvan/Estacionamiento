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
using Estacionamiento.Data;

namespace Estacionamiento.Vistas
{
    public partial class FormCobro : Form
    {
        ControlCobro control = new ControlCobro();
        Vehiculo vehiculo;        
        public FormCobro(string patente)
        {
            InitializeComponent();
            vehiculo = control.TraerDatos(patente);
            txt_patente.Text = vehiculo.patente;
            txt_propietario.Text = vehiculo.nombre;
            //txt_vehiculo.Text =  
            lbl_fechadeentrada.Text = vehiculo.HoraEntrada.ToString();
            lbl_fechadesalida.Text = DateTime.Now.ToString();
            //txt_precio.Text = control.CostoEstadia();
        }

        private void btn_cancelar_carga_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_carga_Click(object sender, EventArgs e)
        {

        }
    }
}
