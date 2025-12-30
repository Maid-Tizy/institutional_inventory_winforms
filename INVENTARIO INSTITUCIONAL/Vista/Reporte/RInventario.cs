using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class RInventario : Form
    {
        public RInventario()
        {
            InitializeComponent();
            controlador = new InventarioControlador();
        }
        InventarioControlador controlador;
        private void RInventario_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();
            rv_inv.LocalReport.DataSources.Clear();
            rv_inv.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_inv.RefreshReport();
        }
    }
}
