using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class RMouse : Form
    {
        public RMouse()
        {
            InitializeComponent();
            controlador = new MouseControlador();
        }
        MouseControlador controlador;
        private void RMouse_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();
            rv_mouse.LocalReport.DataSources.Clear();
            rv_mouse.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_mouse.RefreshReport();
        }
    }
}
