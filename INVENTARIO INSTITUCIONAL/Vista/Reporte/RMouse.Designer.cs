namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class RMouse
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
            this.rv_mouse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_mouse
            // 
            this.rv_mouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_mouse.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.RMouse.rdlc";
            this.rv_mouse.Location = new System.Drawing.Point(0, 0);
            this.rv_mouse.Name = "rv_mouse";
            this.rv_mouse.ServerReport.BearerToken = null;
            this.rv_mouse.Size = new System.Drawing.Size(1200, 318);
            this.rv_mouse.TabIndex = 0;
            // 
            // RMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 318);
            this.Controls.Add(this.rv_mouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RMouse";
            this.Text = "RMouse";
            this.Load += new System.EventHandler(this.RMouse_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_mouse;
    }
}