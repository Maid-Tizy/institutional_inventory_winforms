namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class REspecialidad
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
            this.rv_especialidad = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_especialidad
            // 
            this.rv_especialidad.Location = new System.Drawing.Point(12, 26);
            this.rv_especialidad.Name = "rv_especialidad";
            this.rv_especialidad.ServerReport.BearerToken = null;
            this.rv_especialidad.Size = new System.Drawing.Size(776, 412);
            this.rv_especialidad.TabIndex = 0;
            // 
            // REspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rv_especialidad);
            this.Name = "REspecialidad";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.REspecialidad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_especialidad;
    }
}