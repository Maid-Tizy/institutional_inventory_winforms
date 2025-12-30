using INVENTARIO_INSTITUCIONAL.Controlador;
using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace INVENTARIO_INSTITUCIONAL.Vista.Reporte
{
    public partial class REspecialidad : Form
    {
        EspecialidadControlador controlador;

        public REspecialidad()
        {
            InitializeComponent();
            controlador = new EspecialidadControlador();
        }

        private void REspecialidad_Load(object sender, EventArgs e)
        {
            var data = controlador.GetAll();

            rv_especialidad.Reset(); 
            rv_especialidad.LocalReport.ReportEmbeddedResource = 
                "INVENTARIO_INSTITUCIONAL.Reportes.REespecialidad.rdlc";
            rv_especialidad.LocalReport.DataSources.Clear();
            rv_especialidad.LocalReport.DataSources.Add(
                new ReportDataSource("DataSet1", data) 
            );
            rv_especialidad.RefreshReport();
        }
    }
}
