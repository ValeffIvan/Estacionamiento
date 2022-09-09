﻿using System;
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
    public partial class FormAdministracion : Form
    {
        //inicializar controladores
        ControlLogin listaempleados;
        PrecioAuto precioAuto;
        PrecioMoto precioMoto;
        PrecioCamioneta precioCamioneta;

        public FormAdministracion(ControlLogin empleados, PrecioAuto precioAuto1, PrecioMoto precioMoto1, PrecioCamioneta precioCamioneta1)
        {
            InitializeComponent();
            listaempleados = empleados;
            precioAuto = precioAuto1;
            precioMoto = precioMoto1;
            precioCamioneta = precioCamioneta1;
            dgv_usuarios.DataSource = listaempleados.Listar();
            txt_precio_hora_auto_viejo.Text = precioAuto.hora.ToString();
            txt_precio_hora_camioneta_viejo.Text=precioCamioneta.hora.ToString();
            txt_precio_hora_moto_viejo.Text=precioMoto.hora.ToString();
            txt_precio_mes_camioneta_viejo.Text=precioCamioneta.mes.ToString();
            txt_precio_mes_moto_viejo.Text=precioMoto.mes.ToString();
            txt_precio_mes_auto_viejo.Text=precioAuto.mes.ToString();
            
        }

        private void btn_cambiarvalores_Click(object sender, EventArgs e)
        {
            precioAuto.hora = Convert.ToDouble(txt_precio_hora_auto_nuevo.Text);
            precioCamioneta.hora =Convert.ToDouble(txt_precio_hora_camioneta_nuevo.Text);
            precioMoto.hora = Convert.ToDouble(txt_precio_hora_moto_nuevo.Text);
            precioAuto.mes = Convert.ToDouble(txt_precio_mes_auto_nuevo.Text);
            precioCamioneta.mes = Convert.ToDouble(txt_precio_mes_camioneta_nuevo.Text);
            precioMoto.mes = Convert.ToDouble(txt_precio_mes_moto_nuevo.Text);

        }
    }
}
