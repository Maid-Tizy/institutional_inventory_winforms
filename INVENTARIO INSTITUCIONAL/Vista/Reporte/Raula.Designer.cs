namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class Raula
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
            this.rv_aula = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_aula
            // 
            this.rv_aula.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_aula.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.Raula.rdlc";
            this.rv_aula.Location = new System.Drawing.Point(0, 0);
            this.rv_aula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv_aula.Name = "rv_aula";
            this.rv_aula.ServerReport.BearerToken = null;
            this.rv_aula.Size = new System.Drawing.Size(963, 554);
            this.rv_aula.TabIndex = 0;
            // 
            // Raula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.rv_aula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Raula";
            this.Text = "Raula";
            this.Load += new System.EventHandler(this.Raula_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_aula;
    }
}