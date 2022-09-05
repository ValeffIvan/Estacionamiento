namespace Estacionamiento.Vistas
{
    partial class FormContrasenia
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_corroborarrespuesta = new System.Windows.Forms.Button();
            this.txt_respuestapregunta = new System.Windows.Forms.TextBox();
            this.panel_contranueva = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contranueva = new System.Windows.Forms.TextBox();
            this.lbl_pregunta = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.Verificador = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel_contranueva.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_corroborarrespuesta);
            this.groupBox1.Controls.Add(this.txt_respuestapregunta);
            this.groupBox1.Controls.Add(this.panel_contranueva);
            this.groupBox1.Controls.Add(this.lbl_pregunta);
            this.groupBox1.Controls.Add(this.btn_regresar);
            this.groupBox1.Controls.Add(this.btn_aceptar);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 383);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambiar Contraseña";
            // 
            // btn_corroborarrespuesta
            // 
            this.btn_corroborarrespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_corroborarrespuesta.Location = new System.Drawing.Point(255, 157);
            this.btn_corroborarrespuesta.Name = "btn_corroborarrespuesta";
            this.btn_corroborarrespuesta.Size = new System.Drawing.Size(167, 44);
            this.btn_corroborarrespuesta.TabIndex = 10;
            this.btn_corroborarrespuesta.Text = "Corroborar";
            this.btn_corroborarrespuesta.UseVisualStyleBackColor = true;
            this.btn_corroborarrespuesta.Click += new System.EventHandler(this.btn_corroborarrespuesta_Click);
            // 
            // txt_respuestapregunta
            // 
            this.txt_respuestapregunta.Location = new System.Drawing.Point(13, 157);
            this.txt_respuestapregunta.Name = "txt_respuestapregunta";
            this.txt_respuestapregunta.Size = new System.Drawing.Size(212, 32);
            this.txt_respuestapregunta.TabIndex = 7;
            // 
            // panel_contranueva
            // 
            this.panel_contranueva.Controls.Add(this.label3);
            this.panel_contranueva.Controls.Add(this.txt_contranueva);
            this.panel_contranueva.Location = new System.Drawing.Point(10, 223);
            this.panel_contranueva.Name = "panel_contranueva";
            this.panel_contranueva.Size = new System.Drawing.Size(398, 67);
            this.panel_contranueva.TabIndex = 9;
            this.panel_contranueva.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña nueva:";
            // 
            // txt_contranueva
            // 
            this.txt_contranueva.Location = new System.Drawing.Point(213, 20);
            this.txt_contranueva.Name = "txt_contranueva";
            this.txt_contranueva.Size = new System.Drawing.Size(169, 32);
            this.txt_contranueva.TabIndex = 5;
            // 
            // lbl_pregunta
            // 
            this.lbl_pregunta.AutoSize = true;
            this.lbl_pregunta.Location = new System.Drawing.Point(9, 61);
            this.lbl_pregunta.Name = "lbl_pregunta";
            this.lbl_pregunta.Size = new System.Drawing.Size(97, 23);
            this.lbl_pregunta.TabIndex = 6;
            this.lbl_pregunta.Text = "Pregunta";
            this.lbl_pregunta.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(10, 317);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(180, 60);
            this.btn_regresar.TabIndex = 8;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(272, 317);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(180, 60);
            this.btn_aceptar.TabIndex = 7;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // FormContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 419);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormContrasenia";
            this.Text = "FormContrasenia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_contranueva.ResumeLayout(false);
            this.panel_contranueva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_respuestapregunta;
        private System.Windows.Forms.Panel panel_contranueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contranueva;
        private System.Windows.Forms.Label lbl_pregunta;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_corroborarrespuesta;
        private System.Windows.Forms.ToolTip Verificador;
    }
}