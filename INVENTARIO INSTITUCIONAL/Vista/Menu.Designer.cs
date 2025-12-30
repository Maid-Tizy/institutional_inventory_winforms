namespace INVENTARIO_INSTITUCIONAL.Vista
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.users = new System.Windows.Forms.Button();
            this.pct_minimizar = new System.Windows.Forms.PictureBox();
            this.pct_maximizar = new System.Windows.Forms.PictureBox();
            this.pct_exit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_especialidad = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_teclado = new System.Windows.Forms.Button();
            this.btn_laptop = new System.Windows.Forms.Button();
            this.btn_mouse = new System.Windows.Forms.Button();
            this.btn_cpu = new System.Windows.Forms.Button();
            this.btn_monitor = new System.Windows.Forms.Button();
            this.btn_mobiliaria = new System.Windows.Forms.Button();
            this.btn_equipos = new System.Windows.Forms.Button();
            this.btn_aula = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_exit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_reporte);
            this.panel1.Controls.Add(this.lbl_ad);
            this.panel1.Controls.Add(this.users);
            this.panel1.Controls.Add(this.pct_minimizar);
            this.panel1.Controls.Add(this.pct_maximizar);
            this.panel1.Controls.Add(this.pct_exit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 70);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(522, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 18;
            this.label3.Text = "Reportes :";
            // 
            // btn_reporte
            // 
            this.btn_reporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reporte.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporte.Location = new System.Drawing.Point(622, 23);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(34, 30);
            this.btn_reporte.TabIndex = 17;
            this.btn_reporte.Text = "R";
            this.btn_reporte.UseVisualStyleBackColor = true;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ad.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ad.Location = new System.Drawing.Point(730, 28);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(181, 22);
            this.lbl_ad.TabIndex = 16;
            this.lbl_ad.Text = "Control de usuarios :";
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users.Location = new System.Drawing.Point(917, 22);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(73, 30);
            this.users.TabIndex = 15;
            this.users.Text = "usuarios";
            this.users.UseVisualStyleBackColor = true;
            this.users.Click += new System.EventHandler(this.users_Click);
            // 
            // pct_minimizar
            // 
            this.pct_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_minimizar.Image = global::INVENTARIO_INSTITUCIONAL.Properties.Resources.minimizar1;
            this.pct_minimizar.Location = new System.Drawing.Point(1068, 14);
            this.pct_minimizar.Name = "pct_minimizar";
            this.pct_minimizar.Size = new System.Drawing.Size(45, 39);
            this.pct_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_minimizar.TabIndex = 5;
            this.pct_minimizar.TabStop = false;
            this.pct_minimizar.Click += new System.EventHandler(this.pct_minimizar_Click);
            // 
            // pct_maximizar
            // 
            this.pct_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_maximizar.Image = global::INVENTARIO_INSTITUCIONAL.Properties.Resources.maximizar1;
            this.pct_maximizar.Location = new System.Drawing.Point(1119, 14);
            this.pct_maximizar.Name = "pct_maximizar";
            this.pct_maximizar.Size = new System.Drawing.Size(46, 39);
            this.pct_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_maximizar.TabIndex = 4;
            this.pct_maximizar.TabStop = false;
            this.pct_maximizar.Click += new System.EventHandler(this.pct_maximizar_Click);
            // 
            // pct_exit
            // 
            this.pct_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_exit.Image = global::INVENTARIO_INSTITUCIONAL.Properties.Resources.exit_logo;
            this.pct_exit.Location = new System.Drawing.Point(1171, 14);
            this.pct_exit.Name = "pct_exit";
            this.pct_exit.Size = new System.Drawing.Size(53, 39);
            this.pct_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_exit.TabIndex = 1;
            this.pct_exit.TabStop = false;
            this.pct_exit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(38, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu General de inventario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_especialidad);
            this.panel2.Controls.Add(this.btn_inventario);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.btn_teclado);
            this.panel2.Controls.Add(this.btn_laptop);
            this.panel2.Controls.Add(this.btn_mouse);
            this.panel2.Controls.Add(this.btn_cpu);
            this.panel2.Controls.Add(this.btn_monitor);
            this.panel2.Controls.Add(this.btn_mobiliaria);
            this.panel2.Controls.Add(this.btn_equipos);
            this.panel2.Controls.Add(this.btn_aula);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 718);
            this.panel2.TabIndex = 1;
            // 
            // btn_especialidad
            // 
            this.btn_especialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_especialidad.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_especialidad.Location = new System.Drawing.Point(14, 30);
            this.btn_especialidad.Name = "btn_especialidad";
            this.btn_especialidad.Size = new System.Drawing.Size(187, 42);
            this.btn_especialidad.TabIndex = 15;
            this.btn_especialidad.Text = "Especialidad";
            this.btn_especialidad.UseVisualStyleBackColor = true;
            this.btn_especialidad.Click += new System.EventHandler(this.btn_especialidad_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inventario.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventario.Location = new System.Drawing.Point(14, 402);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(182, 42);
            this.btn_inventario.TabIndex = 14;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = true;
            this.btn_inventario.Click += new System.EventHandler(this.btn_inventario_Click);
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.user.Location = new System.Drawing.Point(32, 656);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 36);
            this.user.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(19, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenido";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::INVENTARIO_INSTITUCIONAL.Properties.Resources.user1;
            this.pictureBox3.Location = new System.Drawing.Point(14, 508);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 145);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btn_teclado
            // 
            this.btn_teclado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teclado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teclado.Location = new System.Drawing.Point(113, 337);
            this.btn_teclado.Name = "btn_teclado";
            this.btn_teclado.Size = new System.Drawing.Size(88, 42);
            this.btn_teclado.TabIndex = 11;
            this.btn_teclado.Text = "Teclado";
            this.btn_teclado.UseVisualStyleBackColor = true;
            this.btn_teclado.Click += new System.EventHandler(this.btn_teclado_Click);
            // 
            // btn_laptop
            // 
            this.btn_laptop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_laptop.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laptop.Location = new System.Drawing.Point(14, 277);
            this.btn_laptop.Name = "btn_laptop";
            this.btn_laptop.Size = new System.Drawing.Size(187, 42);
            this.btn_laptop.TabIndex = 10;
            this.btn_laptop.Text = "Laptop";
            this.btn_laptop.UseVisualStyleBackColor = true;
            this.btn_laptop.Click += new System.EventHandler(this.btn_laptop_Click);
            // 
            // btn_mouse
            // 
            this.btn_mouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mouse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mouse.Location = new System.Drawing.Point(113, 210);
            this.btn_mouse.Name = "btn_mouse";
            this.btn_mouse.Size = new System.Drawing.Size(88, 42);
            this.btn_mouse.TabIndex = 12;
            this.btn_mouse.Text = "Mouse";
            this.btn_mouse.UseVisualStyleBackColor = true;
            this.btn_mouse.Click += new System.EventHandler(this.btn_mouse_Click);
            // 
            // btn_cpu
            // 
            this.btn_cpu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cpu.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cpu.Location = new System.Drawing.Point(14, 210);
            this.btn_cpu.Name = "btn_cpu";
            this.btn_cpu.Size = new System.Drawing.Size(88, 42);
            this.btn_cpu.TabIndex = 8;
            this.btn_cpu.Text = "Cpu";
            this.btn_cpu.UseVisualStyleBackColor = true;
            this.btn_cpu.Click += new System.EventHandler(this.btn_cpu_Click);
            // 
            // btn_monitor
            // 
            this.btn_monitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_monitor.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monitor.Location = new System.Drawing.Point(14, 337);
            this.btn_monitor.Name = "btn_monitor";
            this.btn_monitor.Size = new System.Drawing.Size(88, 42);
            this.btn_monitor.TabIndex = 9;
            this.btn_monitor.Text = "Monitor";
            this.btn_monitor.UseVisualStyleBackColor = true;
            this.btn_monitor.Click += new System.EventHandler(this.btn_monitor_Click);
            // 
            // btn_mobiliaria
            // 
            this.btn_mobiliaria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mobiliaria.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mobiliaria.Location = new System.Drawing.Point(113, 88);
            this.btn_mobiliaria.Name = "btn_mobiliaria";
            this.btn_mobiliaria.Size = new System.Drawing.Size(88, 42);
            this.btn_mobiliaria.TabIndex = 7;
            this.btn_mobiliaria.Text = "Mobiliaria";
            this.btn_mobiliaria.UseVisualStyleBackColor = true;
            this.btn_mobiliaria.Click += new System.EventHandler(this.btn_mobiliaria_Click);
            // 
            // btn_equipos
            // 
            this.btn_equipos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_equipos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_equipos.Location = new System.Drawing.Point(14, 151);
            this.btn_equipos.Name = "btn_equipos";
            this.btn_equipos.Size = new System.Drawing.Size(187, 42);
            this.btn_equipos.TabIndex = 1;
            this.btn_equipos.Text = "Equipos";
            this.btn_equipos.UseVisualStyleBackColor = true;
            this.btn_equipos.Click += new System.EventHandler(this.btn_equipos_Click);
            // 
            // btn_aula
            // 
            this.btn_aula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aula.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aula.Location = new System.Drawing.Point(14, 88);
            this.btn_aula.Name = "btn_aula";
            this.btn_aula.Size = new System.Drawing.Size(88, 42);
            this.btn_aula.TabIndex = 0;
            this.btn_aula.Text = "Aula";
            this.btn_aula.UseVisualStyleBackColor = true;
            this.btn_aula.Click += new System.EventHandler(this.btn_aula_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(212, 70);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1025, 718);
            this.panel.TabIndex = 2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1237, 788);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu General";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_exit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_aula;
        private System.Windows.Forms.Button btn_equipos;
        private System.Windows.Forms.Button btn_monitor;
        private System.Windows.Forms.Button btn_cpu;
        private System.Windows.Forms.Button btn_mobiliaria;
        private System.Windows.Forms.Button btn_mouse;
        private System.Windows.Forms.Button btn_teclado;
        private System.Windows.Forms.Button btn_laptop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pct_exit;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pct_maximizar;
        private System.Windows.Forms.PictureBox pct_minimizar;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Button users;
        private System.Windows.Forms.Button btn_especialidad;
        private System.Windows.Forms.Button btn_reporte;
        private System.Windows.Forms.Label label3;
    }
}