using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class REquipos : Form
    {
        public REquipos()
        {
            InitializeComponent();
            controlador = new EquipoControlador();
        }
        EquipoControlador controlador;
        private void REquipos_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();
            rv_equipo.LocalReport.DataSources.Clear();
            rv_equipo.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_equipo.RefreshReport();
        }
    }
}
