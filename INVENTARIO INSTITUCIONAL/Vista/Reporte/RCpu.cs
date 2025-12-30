using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class RCpu : Form
    {
        public RCpu()
        {
            InitializeComponent();
            controlador = new CpuControlador();
        }
        CpuControlador controlador;
        private void RCpu_Load(object sender, EventArgs e)
        {

            var data = controlador.GetAll();
            rv_cpu.LocalReport.DataSources.Clear();
            rv_cpu.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_cpu.RefreshReport();
        }
    }
}