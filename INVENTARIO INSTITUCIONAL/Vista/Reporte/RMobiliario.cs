using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class RMobiliario : Form
    {
        public RMobiliario()
        {
            InitializeComponent();
            controlador = new MobiliarioControlador();

        }
        MobiliarioControlador controlador;
        private void RMobiliario_Load(object sender, EventArgs e)
        {

            var data = controlador.GetAll();
            rv_mobiliario.LocalReport.DataSources.Clear();
            rv_mobiliario.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_mobiliario.RefreshReport();
        }
    }
}
