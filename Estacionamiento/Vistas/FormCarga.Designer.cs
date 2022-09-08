namespace Estacionamiento.Vistas
{
    partial class FormCarga
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mktxt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_tipovehiculo = new System.Windows.Forms.ComboBox();
            this.txt_caract = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_dia = new System.Windows.Forms.RadioButton();
            this.rbtn_mes = new System.Windows.Forms.RadioButton();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_aceptar_carga = new System.Windows.Forms.Button();
            this.lbl_fechaactual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mktxt_telefono);
            this.groupBox1.Controls.Add(this.txt_apellido);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // mktxt_telefono
            // 
            this.mktxt_telefono.Location = new System.Drawing.Point(112, 82);
            this.mktxt_telefono.Mask = "(999)000-0000";
            this.mktxt_telefono.Name = "mktxt_telefono";
            this.mktxt_telefono.Size = new System.Drawing.Size(165, 32);
            this.mktxt_telefono.TabIndex = 4;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(359, 38);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(136, 32);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(107, 38);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(136, 32);
            this.txt_nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cb_tipovehiculo);
            this.groupBox2.Controls.Add(this.txt_caract);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_patente);
            this.groupBox2.Controls.Add(this.txt_modelo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 241);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Vehiculo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de vehiculo:";
            // 
            // cb_tipovehiculo
            // 
            this.cb_tipovehiculo.FormattingEnabled = true;
            this.cb_tipovehiculo.Items.AddRange(new object[] {
            "Moto",
            "Auto",
            "Camioneta"});
            this.cb_tipovehiculo.Location = new System.Drawing.Point(238, 136);
            this.cb_tipovehiculo.Name = "cb_tipovehiculo";
            this.cb_tipovehiculo.Size = new System.Drawing.Size(180, 31);
            this.cb_tipovehiculo.TabIndex = 12;
            // 
            // txt_caract
            // 
            this.txt_caract.Location = new System.Drawing.Point(223, 189);
            this.txt_caract.Name = "txt_caract";
            this.txt_caract.Size = new System.Drawing.Size(174, 32);
            this.txt_caract.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Caracteristicas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Patente:";
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(183, 85);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(180, 32);
            this.txt_patente.TabIndex = 5;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(183, 38);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(281, 32);
            this.txt_modelo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Modelo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_fechaactual);
            this.groupBox3.Controls.Add(this.rbtn_dia);
            this.groupBox3.Controls.Add(this.rbtn_mes);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 86);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadia";
            // 
            // rbtn_dia
            // 
            this.rbtn_dia.AutoSize = true;
            this.rbtn_dia.Location = new System.Drawing.Point(120, 53);
            this.rbtn_dia.Name = "rbtn_dia";
            this.rbtn_dia.Size = new System.Drawing.Size(75, 27);
            this.rbtn_dia.TabIndex = 10;
            this.rbtn_dia.TabStop = true;
            this.rbtn_dia.Text = "Hora";
            this.rbtn_dia.UseVisualStyleBackColor = true;
            // 
            // rbtn_mes
            // 
            this.rbtn_mes.AutoSize = true;
            this.rbtn_mes.Location = new System.Drawing.Point(308, 53);
            this.rbtn_mes.Name = "rbtn_mes";
            this.rbtn_mes.Size = new System.Drawing.Size(68, 27);
            this.rbtn_mes.TabIndex = 9;
            this.rbtn_mes.TabStop = true;
            this.rbtn_mes.Text = "Mes";
            this.rbtn_mes.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.btn_regresar.Location = new System.Drawing.Point(21, 486);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(181, 63);
            this.btn_regresar.TabIndex = 9;
            this.btn_regresar.Text = "Cancelar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_aceptar_carga
            // 
            this.btn_aceptar_carga.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.btn_aceptar_carga.Location = new System.Drawing.Point(366, 486);
            this.btn_aceptar_carga.Name = "btn_aceptar_carga";
            this.btn_aceptar_carga.Size = new System.Drawing.Size(180, 63);
            this.btn_aceptar_carga.TabIndex = 10;
            this.btn_aceptar_carga.Text = "Aceptar";
            this.btn_aceptar_carga.UseVisualStyleBackColor = true;
            this.btn_aceptar_carga.Click += new System.EventHandler(this.btn_aceptar_carga_Click);
            // 
            // lbl_fechaactual
            // 
            this.lbl_fechaactual.AutoSize = true;
            this.lbl_fechaactual.Location = new System.Drawing.Point(179, 27);
            this.lbl_fechaactual.Name = "lbl_fechaactual";
            this.lbl_fechaactual.Size = new System.Drawing.Size(124, 23);
            this.lbl_fechaactual.TabIndex = 11;
            this.lbl_fechaactual.Text = "fecha actual";
            // 
            // FormCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btn_aceptar_carga);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCarga";
            this.Text = "FormCarga";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mktxt_telefono;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_mes;
        private System.Windows.Forms.RadioButton rbtn_dia;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_aceptar_carga;
        private System.Windows.Forms.TextBox txt_caract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_tipovehiculo;
        private System.Windows.Forms.Label lbl_fechaactual;
    }
}