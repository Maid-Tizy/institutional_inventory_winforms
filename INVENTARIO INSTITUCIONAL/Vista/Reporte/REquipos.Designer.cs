namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class REquipos
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
            this.rv_equipo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_equipo
            // 
            this.rv_equipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_equipo.DocumentMapWidth = 29;
            this.rv_equipo.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.REquipos.rdlc";
            this.rv_equipo.Location = new System.Drawing.Point(0, 0);
            this.rv_equipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_equipo.Name = "rv_equipo";
            this.rv_equipo.ServerReport.BearerToken = null;
            this.rv_equipo.Size = new System.Drawing.Size(1172, 442);
            this.rv_equipo.TabIndex = 0;
            // 
            // REquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 442);
            this.Controls.Add(this.rv_equipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "REquipos";
            this.Text = "REquipos";
            this.Load += new System.EventHandler(this.REquipos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_equipo;
    }
}