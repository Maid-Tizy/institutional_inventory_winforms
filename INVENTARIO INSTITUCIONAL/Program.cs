using INVENTARIO_INSTITUCIONAL.Vista;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
