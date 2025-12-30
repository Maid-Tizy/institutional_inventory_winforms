namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class RMobiliario
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
            this.rv_mobiliario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_mobiliario
            // 
            this.rv_mobiliario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_mobiliario.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.RMobiliario.rdlc";
            this.rv_mobiliario.Location = new System.Drawing.Point(0, 0);
            this.rv_mobiliario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_mobiliario.Name = "rv_mobiliario";
            this.rv_mobiliario.ServerReport.BearerToken = null;
            this.rv_mobiliario.Size = new System.Drawing.Size(1286, 387);
            this.rv_mobiliario.TabIndex = 0;
            // 
            // RMobiliario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 387);
            this.Controls.Add(this.rv_mobiliario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RMobiliario";
            this.Text = "RMobiliario";
            this.Load += new System.EventHandler(this.RMobiliario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_mobiliario;
    }
}