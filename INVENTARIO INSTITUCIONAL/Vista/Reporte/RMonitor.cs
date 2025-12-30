using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class RMonitor : Form
    {
        public RMonitor()
        {
            InitializeComponent();
            controlador = new MonitorControlador();
        }
        MonitorControlador controlador;
        private void RMonitor_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();
            rv_monitor.LocalReport.DataSources.Clear();
            rv_monitor.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_monitor.RefreshReport();
        }
    }
}
