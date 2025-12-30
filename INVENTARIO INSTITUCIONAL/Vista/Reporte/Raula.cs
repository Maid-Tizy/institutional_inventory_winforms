using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class Raula : Form
    {
        public Raula()
        {
            InitializeComponent();
            controlador = new AulaControlador();
        }
        AulaControlador controlador;
        private void Raula_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();
            rv_aula.LocalReport.DataSources.Clear();
            rv_aula.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",data));
            this.rv_aula.RefreshReport();
        }
    }
}
