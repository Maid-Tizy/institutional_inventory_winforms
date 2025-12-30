namespace INVENTARIO_INSTITUCIONAL.Vista
{
    partial class Aula
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbo_sede = new System.Windows.Forms.ComboBox();
            this.cbo_tipo_aula = new System.Windows.Forms.ComboBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ancho = new System.Windows.Forms.TextBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.txt_largo = new System.Windows.Forms.TextBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.lbl_m = new System.Windows.Forms.Label();
            this.mensaje = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.dt_aulas = new System.Windows.Forms.DataGridView();
            this.pct_return = new System.Windows.Forms.PictureBox();
            this.cbo_especialidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_aulas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_return)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbo_especialidad);
            this.panel2.Controls.Add(this.cbo_sede);
            this.panel2.Controls.Add(this.cbo_tipo_aula);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_ancho);
            this.panel2.Controls.Add(this.txt_area);
            this.panel2.Controls.Add(this.txt_largo);
            this.panel2.Controls.Add(this.txt_descripcion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_insertar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 668);
            this.panel2.TabIndex = 24;
            // 
            // cbo_sede
            // 
            this.cbo_sede.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_sede.FormattingEnabled = true;
            this.cbo_sede.Items.AddRange(new object[] {
            "Villa Alejandro",
            "Upis"});
            this.cbo_sede.Location = new System.Drawing.Point(123, 435);
            this.cbo_sede.Name = "cbo_sede";
            this.cbo_sede.Size = new System.Drawing.Size(121, 21);
            this.cbo_sede.TabIndex = 28;
            // 
            // cbo_tipo_aula
            // 
            this.cbo_tipo_aula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_tipo_aula.FormattingEnabled = true;
            this.cbo_tipo_aula.Items.AddRange(new object[] {
            "Salon",
            "Taller",
            "laboratorio"});
            this.cbo_tipo_aula.Location = new System.Drawing.Point(123, 391);
            this.cbo_tipo_aula.Name = "cbo_tipo_aula";
            this.cbo_tipo_aula.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipo_aula.TabIndex = 27;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevo.Location = new System.Drawing.Point(144, 610);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 33);
            this.btn_nuevo.TabIndex = 26;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.Location = new System.Drawing.Point(144, 556);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 33);
            this.btn_actualizar.TabIndex = 24;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.Location = new System.Drawing.Point(24, 610);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 33);
            this.btn_eliminar.TabIndex = 23;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click_1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sede";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tipo de aula";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Largo";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Area";
            // 
            // txt_ancho
            // 
            this.txt_ancho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ancho.Location = new System.Drawing.Point(123, 279);
            this.txt_ancho.Name = "txt_ancho";
            this.txt_ancho.Size = new System.Drawing.Size(121, 20);
            this.txt_ancho.TabIndex = 10;
            // 
            // txt_area
            // 
            this.txt_area.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_area.Location = new System.Drawing.Point(123, 237);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(121, 20);
            this.txt_area.TabIndex = 9;
            // 
            // txt_largo
            // 
            this.txt_largo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_largo.Location = new System.Drawing.Point(123, 320);
            this.txt_largo.Name = "txt_largo";
            this.txt_largo.Size = new System.Drawing.Size(121, 20);
            this.txt_largo.TabIndex = 8;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descripcion.Location = new System.Drawing.Point(24, 128);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(220, 73);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_insertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insertar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insertar.Location = new System.Drawing.Point(24, 556);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(100, 33);
            this.btn_insertar.TabIndex = 3;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click_1);
            // 
            // lbl_m
            // 
            this.lbl_m.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_m.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_m.Location = new System.Drawing.Point(360, 612);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(915, 45);
            this.lbl_m.TabIndex = 37;
            // 
            // mensaje
            // 
            this.mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mensaje.AutoSize = true;
            this.mensaje.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensaje.Location = new System.Drawing.Point(280, 627);
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(64, 19);
            this.mensaje.TabIndex = 36;
            this.mensaje.Text = "Mensaje:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(300, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(476, 73);
            this.title.TabIndex = 34;
            this.title.Text = "Formulario Aulas";
            // 
            // dt_aulas
            // 
            this.dt_aulas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_aulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_aulas.Location = new System.Drawing.Point(300, 100);
            this.dt_aulas.Name = "dt_aulas";
            this.dt_aulas.RowHeadersWidth = 51;
            this.dt_aulas.Size = new System.Drawing.Size(975, 482);
            this.dt_aulas.TabIndex = 33;
            this.dt_aulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_aulas_CellClick);
            // 
            // pct_return
            // 
            this.pct_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_return.Image = global::INVENTARIO_INSTITUCIONAL.Properties.Resources.resources;
            this.pct_return.Location = new System.Drawing.Point(1351, 25);
            this.pct_return.Name = "pct_return";
            this.pct_return.Size = new System.Drawing.Size(61, 56);
            this.pct_return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pct_return.TabIndex = 38;
            this.pct_return.TabStop = false;
            this.pct_return.Click += new System.EventHandler(this.pct_return_Click);
            // 
            // cbo_especialidad
            // 
            this.cbo_especialidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_especialidad.FormattingEnabled = true;
            this.cbo_especialidad.Items.AddRange(new object[] {
            "Villa Alejandro",
            "Upis"});
            this.cbo_especialidad.Location = new System.Drawing.Point(123, 481);
            this.cbo_especialidad.Name = "cbo_especialidad";
            this.cbo_especialidad.Size = new System.Drawing.Size(121, 21);
            this.cbo_especialidad.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Especialidad";
            // 
            // Aula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1316, 668);
            this.Controls.Add(this.pct_return);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.title);
            this.Controls.Add(this.dt_aulas);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aula";
            this.Text = "Aula";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_aulas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ancho;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.TextBox txt_largo;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.PictureBox pct_return;
        private System.Windows.Forms.Label lbl_m;
        private System.Windows.Forms.Label mensaje;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_sede;
        private System.Windows.Forms.ComboBox cbo_tipo_aula;
        private System.Windows.Forms.DataGridView dt_aulas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_especialidad;
    }
}