namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    partial class Rusers
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
            this.rv_user = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rv_user
            // 
            this.rv_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv_user.LocalReport.ReportEmbeddedResource = "INVENTARIO_INSTITUCIONAL.Reportes.Rusers.rdlc";
            this.rv_user.Location = new System.Drawing.Point(0, 0);
            this.rv_user.Name = "rv_user";
            this.rv_user.ServerReport.BearerToken = null;
            this.rv_user.Size = new System.Drawing.Size(800, 324);
            this.rv_user.TabIndex = 0;
            // 
            // Rusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.rv_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Rusers";
            this.Text = "Rusers";
            this.Load += new System.EventHandler(this.Rusers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_user;
    }
}