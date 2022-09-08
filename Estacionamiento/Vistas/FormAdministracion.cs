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
    public partial class FormAdministracion : Form
    {
        //inicializar controladores
        ControlEmpleados empleados;
        
        public FormAdministracion()
        {
            InitializeComponent();
            dgv_usuarios.DataSource = empleados;
        }


        

    }
}
