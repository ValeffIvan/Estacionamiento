namespace Estacionamiento.Vistas
{
    partial class FormAdministracion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tarifas = new System.Windows.Forms.TabPage();
            this.btn_cambiarvalores = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_precio_mes_camioneta_nuevo = new System.Windows.Forms.TextBox();
            this.txt_precio_mes_auto_nuevo = new System.Windows.Forms.TextBox();
            this.txt_precio_mes_moto_nuevo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_precio_hora_camioneta_viejo = new System.Windows.Forms.TextBox();
            this.txt_precio_hora_auto_viejo = new System.Windows.Forms.TextBox();
            this.txt_precio_hora_moto_viejo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_precio_hora_camioneta_nuevo = new System.Windows.Forms.TextBox();
            this.txt_precio_hora_auto_nuevo = new System.Windows.Forms.TextBox();
            this.txt_precio_hora_moto_nuevo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_precio_mes_camioneta_viejo = new System.Windows.Forms.TextBox();
            this.txt_precio_mes_auto_viejo = new System.Windows.Forms.TextBox();
            this.txt_precio_mes_moto_viejo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Facturacion = new System.Windows.Forms.TabPage();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.btn_actualizar_usuarios = new System.Windows.Forms.Button();
            this.btn_agregar_usuarios = new System.Windows.Forms.Button();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Tarifas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Facturacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tarifas);
            this.tabControl1.Controls.Add(this.Facturacion);
            this.tabControl1.Controls.Add(this.Usuarios);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // Tarifas
            // 
            this.Tarifas.Controls.Add(this.btn_cambiarvalores);
            this.Tarifas.Controls.Add(this.button26);
            this.Tarifas.Controls.Add(this.button25);
            this.Tarifas.Controls.Add(this.label1);
            this.Tarifas.Controls.Add(this.groupBox4);
            this.Tarifas.Controls.Add(this.groupBox1);
            this.Tarifas.Controls.Add(this.groupBox6);
            this.Tarifas.Controls.Add(this.groupBox3);
            this.Tarifas.Controls.Add(this.label2);
            this.Tarifas.Location = new System.Drawing.Point(4, 22);
            this.Tarifas.Name = "Tarifas";
            this.Tarifas.Padding = new System.Windows.Forms.Padding(3);
            this.Tarifas.Size = new System.Drawing.Size(928, 426);
            this.Tarifas.TabIndex = 0;
            this.Tarifas.Text = "Tarifas";
            this.Tarifas.UseVisualStyleBackColor = true;
            // 
            // btn_cambiarvalores
            // 
            this.btn_cambiarvalores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiarvalores.Location = new System.Drawing.Point(553, 373);
            this.btn_cambiarvalores.Name = "btn_cambiarvalores";
            this.btn_cambiarvalores.Size = new System.Drawing.Size(146, 48);
            this.btn_cambiarvalores.TabIndex = 21;
            this.btn_cambiarvalores.Text = "Cambiar valores";
            this.btn_cambiarvalores.UseVisualStyleBackColor = true;
            this.btn_cambiarvalores.Click += new System.EventHandler(this.btn_cambiarvalores_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(133, 493);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(180, 60);
            this.button26.TabIndex = 20;
            this.button26.Text = "Guardar";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(-101, 493);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(180, 60);
            this.button25.TabIndex = 3;
            this.button25.Text = "Cancelar";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarifas Actuales";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_precio_mes_camioneta_nuevo);
            this.groupBox4.Controls.Add(this.txt_precio_mes_auto_nuevo);
            this.groupBox4.Controls.Add(this.txt_precio_mes_moto_nuevo);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(380, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(276, 140);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mensual";
            // 
            // txt_precio_mes_camioneta_nuevo
            // 
            this.txt_precio_mes_camioneta_nuevo.Location = new System.Drawing.Point(140, 103);
            this.txt_precio_mes_camioneta_nuevo.Name = "txt_precio_mes_camioneta_nuevo";
            this.txt_precio_mes_camioneta_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_camioneta_nuevo.TabIndex = 20;
            // 
            // txt_precio_mes_auto_nuevo
            // 
            this.txt_precio_mes_auto_nuevo.Location = new System.Drawing.Point(140, 65);
            this.txt_precio_mes_auto_nuevo.Name = "txt_precio_mes_auto_nuevo";
            this.txt_precio_mes_auto_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_auto_nuevo.TabIndex = 19;
            // 
            // txt_precio_mes_moto_nuevo
            // 
            this.txt_precio_mes_moto_nuevo.Location = new System.Drawing.Point(140, 27);
            this.txt_precio_mes_moto_nuevo.Name = "txt_precio_mes_moto_nuevo";
            this.txt_precio_mes_moto_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_moto_nuevo.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Auto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Moto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Camioneta:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_precio_hora_camioneta_viejo);
            this.groupBox1.Controls.Add(this.txt_precio_hora_auto_viejo);
            this.groupBox1.Controls.Add(this.txt_precio_hora_moto_viejo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 139);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Por hora";
            // 
            // txt_precio_hora_camioneta_viejo
            // 
            this.txt_precio_hora_camioneta_viejo.Location = new System.Drawing.Point(140, 101);
            this.txt_precio_hora_camioneta_viejo.Name = "txt_precio_hora_camioneta_viejo";
            this.txt_precio_hora_camioneta_viejo.ReadOnly = true;
            this.txt_precio_hora_camioneta_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_camioneta_viejo.TabIndex = 17;
            // 
            // txt_precio_hora_auto_viejo
            // 
            this.txt_precio_hora_auto_viejo.Location = new System.Drawing.Point(140, 63);
            this.txt_precio_hora_auto_viejo.Name = "txt_precio_hora_auto_viejo";
            this.txt_precio_hora_auto_viejo.ReadOnly = true;
            this.txt_precio_hora_auto_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_auto_viejo.TabIndex = 16;
            // 
            // txt_precio_hora_moto_viejo
            // 
            this.txt_precio_hora_moto_viejo.Location = new System.Drawing.Point(140, 24);
            this.txt_precio_hora_moto_viejo.Name = "txt_precio_hora_moto_viejo";
            this.txt_precio_hora_moto_viejo.ReadOnly = true;
            this.txt_precio_hora_moto_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_moto_viejo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Auto:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Moto:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 21);
            this.label14.TabIndex = 14;
            this.label14.Text = "Camioneta:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_precio_hora_camioneta_nuevo);
            this.groupBox6.Controls.Add(this.txt_precio_hora_auto_nuevo);
            this.groupBox6.Controls.Add(this.txt_precio_hora_moto_nuevo);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(55, 228);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(263, 139);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Por hora";
            // 
            // txt_precio_hora_camioneta_nuevo
            // 
            this.txt_precio_hora_camioneta_nuevo.Location = new System.Drawing.Point(140, 101);
            this.txt_precio_hora_camioneta_nuevo.Name = "txt_precio_hora_camioneta_nuevo";
            this.txt_precio_hora_camioneta_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_camioneta_nuevo.TabIndex = 17;
            // 
            // txt_precio_hora_auto_nuevo
            // 
            this.txt_precio_hora_auto_nuevo.Location = new System.Drawing.Point(140, 63);
            this.txt_precio_hora_auto_nuevo.Name = "txt_precio_hora_auto_nuevo";
            this.txt_precio_hora_auto_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_auto_nuevo.TabIndex = 16;
            // 
            // txt_precio_hora_moto_nuevo
            // 
            this.txt_precio_hora_moto_nuevo.Location = new System.Drawing.Point(140, 24);
            this.txt_precio_hora_moto_nuevo.Name = "txt_precio_hora_moto_nuevo";
            this.txt_precio_hora_moto_nuevo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_hora_moto_nuevo.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "Auto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 21);
            this.label11.TabIndex = 13;
            this.label11.Text = "Moto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Camioneta:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_precio_mes_camioneta_viejo);
            this.groupBox3.Controls.Add(this.txt_precio_mes_auto_viejo);
            this.groupBox3.Controls.Add(this.txt_precio_mes_moto_viejo);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(380, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 135);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mensual";
            // 
            // txt_precio_mes_camioneta_viejo
            // 
            this.txt_precio_mes_camioneta_viejo.Location = new System.Drawing.Point(140, 97);
            this.txt_precio_mes_camioneta_viejo.Name = "txt_precio_mes_camioneta_viejo";
            this.txt_precio_mes_camioneta_viejo.ReadOnly = true;
            this.txt_precio_mes_camioneta_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_camioneta_viejo.TabIndex = 20;
            // 
            // txt_precio_mes_auto_viejo
            // 
            this.txt_precio_mes_auto_viejo.Location = new System.Drawing.Point(140, 58);
            this.txt_precio_mes_auto_viejo.Name = "txt_precio_mes_auto_viejo";
            this.txt_precio_mes_auto_viejo.ReadOnly = true;
            this.txt_precio_mes_auto_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_auto_viejo.TabIndex = 19;
            // 
            // txt_precio_mes_moto_viejo
            // 
            this.txt_precio_mes_moto_viejo.Location = new System.Drawing.Point(140, 20);
            this.txt_precio_mes_moto_viejo.Name = "txt_precio_mes_moto_viejo";
            this.txt_precio_mes_moto_viejo.ReadOnly = true;
            this.txt_precio_mes_moto_viejo.Size = new System.Drawing.Size(100, 32);
            this.txt_precio_mes_moto_viejo.TabIndex = 18;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "Auto:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 21);
            this.label19.TabIndex = 13;
            this.label19.Text = "Moto:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 107);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 21);
            this.label20.TabIndex = 14;
            this.label20.Text = "Camioneta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.label2.Location = new System.Drawing.Point(18, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevas Tarifas";
            // 
            // Facturacion
            // 
            this.Facturacion.Controls.Add(this.btn_actualizar);
            this.Facturacion.Controls.Add(this.dgv_vehiculos);
            this.Facturacion.Location = new System.Drawing.Point(4, 22);
            this.Facturacion.Name = "Facturacion";
            this.Facturacion.Padding = new System.Windows.Forms.Padding(3);
            this.Facturacion.Size = new System.Drawing.Size(928, 426);
            this.Facturacion.TabIndex = 1;
            this.Facturacion.Text = "Facturacion";
            this.Facturacion.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(835, 133);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(87, 92);
            this.btn_actualizar.TabIndex = 1;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // dgv_vehiculos
            // 
            this.dgv_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vehiculos.Enabled = false;
            this.dgv_vehiculos.Location = new System.Drawing.Point(3, 3);
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.ReadOnly = true;
            this.dgv_vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
            this.dgv_vehiculos.Size = new System.Drawing.Size(826, 420);
            this.dgv_vehiculos.TabIndex = 0;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.btn_actualizar_usuarios);
            this.Usuarios.Controls.Add(this.btn_agregar_usuarios);
            this.Usuarios.Controls.Add(this.dgv_usuarios);
            this.Usuarios.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(928, 426);
            this.Usuarios.TabIndex = 2;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar_usuarios
            // 
            this.btn_actualizar_usuarios.Location = new System.Drawing.Point(812, 255);
            this.btn_actualizar_usuarios.Name = "btn_actualizar_usuarios";
            this.btn_actualizar_usuarios.Size = new System.Drawing.Size(113, 74);
            this.btn_actualizar_usuarios.TabIndex = 3;
            this.btn_actualizar_usuarios.Text = "Actualizar";
            this.btn_actualizar_usuarios.UseVisualStyleBackColor = true;
            this.btn_actualizar_usuarios.Click += new System.EventHandler(this.btn_actualizar_usuarios_Click);
            // 
            // btn_agregar_usuarios
            // 
            this.btn_agregar_usuarios.Location = new System.Drawing.Point(812, 67);
            this.btn_agregar_usuarios.Name = "btn_agregar_usuarios";
            this.btn_agregar_usuarios.Size = new System.Drawing.Size(113, 74);
            this.btn_agregar_usuarios.TabIndex = 1;
            this.btn_agregar_usuarios.Text = "Agregar";
            this.btn_agregar_usuarios.UseVisualStyleBackColor = true;
            this.btn_agregar_usuarios.Click += new System.EventHandler(this.btn_agregar_usuarios_Click);
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Enabled = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(0, 0);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(806, 426);
            this.dgv_usuarios.TabIndex = 0;
            // 
            // FormAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdministracion";
            this.Text = "FormAdministracion";
            this.tabControl1.ResumeLayout(false);
            this.Tarifas.ResumeLayout(false);
            this.Tarifas.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Facturacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.Usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tarifas;
        private System.Windows.Forms.TabPage Facturacion;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_precio_mes_camioneta_nuevo;
        private System.Windows.Forms.TextBox txt_precio_mes_auto_nuevo;
        private System.Windows.Forms.TextBox txt_precio_mes_moto_nuevo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_precio_hora_camioneta_nuevo;
        private System.Windows.Forms.TextBox txt_precio_hora_auto_nuevo;
        private System.Windows.Forms.TextBox txt_precio_hora_moto_nuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_precio_hora_camioneta_viejo;
        private System.Windows.Forms.TextBox txt_precio_hora_auto_viejo;
        private System.Windows.Forms.TextBox txt_precio_hora_moto_viejo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_precio_mes_camioneta_viejo;
        private System.Windows.Forms.TextBox txt_precio_mes_auto_viejo;
        private System.Windows.Forms.TextBox txt_precio_mes_moto_viejo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.DataGridView dgv_vehiculos;
        private System.Windows.Forms.Button btn_cambiarvalores;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_actualizar_usuarios;
        private System.Windows.Forms.Button btn_agregar_usuarios;
    }
}