namespace Estacionamiento.Vistas
{
    partial class FormCobro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_aceptar_carga = new System.Windows.Forms.Button();
            this.btn_cancelar_carga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_propietario = new System.Windows.Forms.TextBox();
            this.txt_vehiculo = new System.Windows.Forms.TextBox();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_fechadesalida = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_fechadeentrada = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_aceptar_carga
            // 
            this.btn_aceptar_carga.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.btn_aceptar_carga.Location = new System.Drawing.Point(377, 463);
            this.btn_aceptar_carga.Name = "btn_aceptar_carga";
            this.btn_aceptar_carga.Size = new System.Drawing.Size(180, 75);
            this.btn_aceptar_carga.TabIndex = 11;
            this.btn_aceptar_carga.Text = "Cobrar";
            this.btn_aceptar_carga.UseVisualStyleBackColor = true;
            this.btn_aceptar_carga.Click += new System.EventHandler(this.btn_aceptar_carga_Click);
            // 
            // btn_cancelar_carga
            // 
            this.btn_cancelar_carga.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.btn_cancelar_carga.Location = new System.Drawing.Point(25, 463);
            this.btn_cancelar_carga.Name = "btn_cancelar_carga";
            this.btn_cancelar_carga.Size = new System.Drawing.Size(180, 75);
            this.btn_cancelar_carga.TabIndex = 12;
            this.btn_cancelar_carga.Text = "Cancelar";
            this.btn_cancelar_carga.UseVisualStyleBackColor = true;
            this.btn_cancelar_carga.Click += new System.EventHandler(this.btn_cancelar_carga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txt_propietario);
            this.groupBox1.Controls.Add(this.txt_vehiculo);
            this.groupBox1.Controls.Add(this.txt_patente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 151);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehiculo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(153, 32);
            this.textBox1.TabIndex = 15;
            // 
            // txt_propietario
            // 
            this.txt_propietario.Location = new System.Drawing.Point(402, 50);
            this.txt_propietario.Name = "txt_propietario";
            this.txt_propietario.ReadOnly = true;
            this.txt_propietario.Size = new System.Drawing.Size(152, 32);
            this.txt_propietario.TabIndex = 15;
            // 
            // txt_vehiculo
            // 
            this.txt_vehiculo.Location = new System.Drawing.Point(117, 102);
            this.txt_vehiculo.Name = "txt_vehiculo";
            this.txt_vehiculo.ReadOnly = true;
            this.txt_vehiculo.Size = new System.Drawing.Size(144, 32);
            this.txt_vehiculo.TabIndex = 15;
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(102, 50);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.ReadOnly = true;
            this.txt_patente.Size = new System.Drawing.Size(159, 32);
            this.txt_patente.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Propietario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Patente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 136);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "(Estadia Mes/Hora)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio $";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(299, 86);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.ReadOnly = true;
            this.txt_precio.Size = new System.Drawing.Size(103, 32);
            this.txt_precio.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_fechadesalida);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lbl_fechadeentrada);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 122);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha";
            // 
            // lbl_fechadesalida
            // 
            this.lbl_fechadesalida.AutoSize = true;
            this.lbl_fechadesalida.Location = new System.Drawing.Point(325, 81);
            this.lbl_fechadesalida.Name = "lbl_fechadesalida";
            this.lbl_fechadesalida.Size = new System.Drawing.Size(177, 23);
            this.lbl_fechadesalida.TabIndex = 19;
            this.lbl_fechadesalida.Text = "Fecha de entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(306, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Fecha de salida";
            // 
            // lbl_fechadeentrada
            // 
            this.lbl_fechadeentrada.AutoSize = true;
            this.lbl_fechadeentrada.Location = new System.Drawing.Point(56, 81);
            this.lbl_fechadeentrada.Name = "lbl_fechadeentrada";
            this.lbl_fechadeentrada.Size = new System.Drawing.Size(177, 23);
            this.lbl_fechadeentrada.TabIndex = 17;
            this.lbl_fechadeentrada.Text = "Fecha de entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha de entrada";
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar_carga);
            this.Controls.Add(this.btn_aceptar_carga);
            this.Name = "FormCobro";
            this.Text = "Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_aceptar_carga;
        private System.Windows.Forms.Button btn_cancelar_carga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_propietario;
        private System.Windows.Forms.TextBox txt_vehiculo;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_fechadesalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_fechadeentrada;
        private System.Windows.Forms.Label label7;
    }
}