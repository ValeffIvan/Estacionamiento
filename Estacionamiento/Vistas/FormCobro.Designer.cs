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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.txt_vehiculo = new System.Windows.Forms.TextBox();
            this.txt_propietario = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(560, 171);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehiculo";
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
            this.groupBox2.Location = new System.Drawing.Point(12, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 171);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estadia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "(Estadia Mes/Hora)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio $";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(294, 125);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(103, 32);
            this.txt_precio.TabIndex = 14;
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(102, 50);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(159, 32);
            this.txt_patente.TabIndex = 15;
            // 
            // txt_vehiculo
            // 
            this.txt_vehiculo.Location = new System.Drawing.Point(117, 102);
            this.txt_vehiculo.Name = "txt_vehiculo";
            this.txt_vehiculo.Size = new System.Drawing.Size(144, 32);
            this.txt_vehiculo.TabIndex = 15;
            // 
            // txt_propietario
            // 
            this.txt_propietario.Location = new System.Drawing.Point(402, 50);
            this.txt_propietario.Name = "txt_propietario";
            this.txt_propietario.Size = new System.Drawing.Size(152, 32);
            this.txt_propietario.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 32);
            this.textBox1.TabIndex = 15;
            // 
            // FormCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.ControlBox = false;
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
    }
}