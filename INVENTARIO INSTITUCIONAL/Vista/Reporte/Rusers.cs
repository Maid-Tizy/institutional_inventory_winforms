using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class Rusers : Form
    {
        public Rusers()
        {
            InitializeComponent();
            controlador = new UsuarioControlador();
        }
        UsuarioControlador controlador;
        private void Rusers_Load(object sender, EventArgs e)
        {

            var data = controlador.GetAll();
            rv_user.LocalReport.DataSources.Clear();
            rv_user.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data));
            this.rv_user.RefreshReport();
        }
    }
}
