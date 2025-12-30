namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class RInventario
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
            this.rv_inv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_inv
            // 
            this.rv_inv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_inv.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.RInventario.rdlc";
            this.rv_inv.Location = new System.Drawing.Point(0, 0);
            this.rv_inv.Name = "rv_inv";
            this.rv_inv.ServerReport.BearerToken = null;
            this.rv_inv.Size = new System.Drawing.Size(868, 414);
            this.rv_inv.TabIndex = 0;
            // 
            // RInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 414);
            this.Controls.Add(this.rv_inv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RInventario";
            this.Text = "RInventario";
            this.Load += new System.EventHandler(this.RInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_inv;
    }
}