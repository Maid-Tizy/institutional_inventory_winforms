namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class RMonitor
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
            this.rv_monitor = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_monitor
            // 
            this.rv_monitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_monitor.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.RMonitor.rdlc";
            this.rv_monitor.Location = new System.Drawing.Point(0, 0);
            this.rv_monitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_monitor.Name = "rv_monitor";
            this.rv_monitor.ServerReport.BearerToken = null;
            this.rv_monitor.Size = new System.Drawing.Size(1274, 385);
            this.rv_monitor.TabIndex = 0;
            // 
            // RMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 385);
            this.Controls.Add(this.rv_monitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RMonitor";
            this.Text = "RMonitor";
            this.Load += new System.EventHandler(this.RMonitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_monitor;
    }
}