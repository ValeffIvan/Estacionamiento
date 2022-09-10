namespace Estacionamiento.Vistas
{
    partial class FormAgregarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_pregunta = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.npd_documento = new System.Windows.Forms.NumericUpDown();
            this.txt_respuesta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbutton_admin = new System.Windows.Forms.RadioButton();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.npd_documento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(15, 44);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(111, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(152, 44);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(127, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de documento";
            // 
            // cb_pregunta
            // 
            this.cb_pregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pregunta.FormattingEnabled = true;
            this.cb_pregunta.Items.AddRange(new object[] {
            "Nombre de su primera mascota",
            "Cual fue tu primer auto",
            "Cual es tu pelicula favorita",
            "Nombre de tu hermano/a",
            "Banda favorita"});
            this.cb_pregunta.Location = new System.Drawing.Point(12, 241);
            this.cb_pregunta.Name = "cb_pregunta";
            this.cb_pregunta.Size = new System.Drawing.Size(214, 21);
            this.cb_pregunta.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(15, 176);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(132, 20);
            this.txt_contraseña.TabIndex = 8;
            // 
            // npd_documento
            // 
            this.npd_documento.Location = new System.Drawing.Point(15, 114);
            this.npd_documento.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.npd_documento.Name = "npd_documento";
            this.npd_documento.Size = new System.Drawing.Size(132, 20);
            this.npd_documento.TabIndex = 9;
            // 
            // txt_respuesta
            // 
            this.txt_respuesta.Location = new System.Drawing.Point(12, 307);
            this.txt_respuesta.Name = "txt_respuesta";
            this.txt_respuesta.Size = new System.Drawing.Size(132, 20);
            this.txt_respuesta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pregunta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Respuesta";
            // 
            // rbutton_admin
            // 
            this.rbutton_admin.AutoSize = true;
            this.rbutton_admin.Location = new System.Drawing.Point(191, 307);
            this.rbutton_admin.Name = "rbutton_admin";
            this.rbutton_admin.Size = new System.Drawing.Size(88, 17);
            this.rbutton_admin.TabIndex = 13;
            this.rbutton_admin.TabStop = true;
            this.rbutton_admin.Text = "Administrador";
            this.rbutton_admin.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(166, 360);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(113, 70);
            this.btn_aceptar.TabIndex = 14;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(11, 360);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(115, 70);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FormAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 442);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.rbutton_admin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_respuesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.npd_documento);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_pregunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregarUsuario";
            this.Text = "FormAgregarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.npd_documento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_pregunta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.NumericUpDown npd_documento;
        private System.Windows.Forms.TextBox txt_respuesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbutton_admin;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}