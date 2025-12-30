namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class RCpu
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
            this.rv_cpu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_cpu
            // 
            this.rv_cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_cpu.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.RCpu.rdlc";
            this.rv_cpu.Location = new System.Drawing.Point(0, 0);
            this.rv_cpu.Margin = new System.Windows.Forms.Padding(4);
            this.rv_cpu.Name = "rv_cpu";
            this.rv_cpu.ServerReport.BearerToken = null;
            this.rv_cpu.Size = new System.Drawing.Size(1527, 608);
            this.rv_cpu.TabIndex = 0;
            // 
            // RCpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 608);
            this.Controls.Add(this.rv_cpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RCpu";
            this.Text = "RCpu";
            this.Load += new System.EventHandler(this.RCpu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_cpu;
    }
}