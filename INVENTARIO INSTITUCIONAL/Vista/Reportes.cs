using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Threading;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Reportes : Form
    {
        private static Raula raula = null;
        private static RCpu rcpu = null;
        private static REquipos reEquipos = null;
        private static REspecialidad rEspecialidad = null;
        private static RInventario rInventario = null;
        private static Rusers rusers = null;
        private static RMobiliario rMobiliario = null;
        private static RMouse rMouse = null;
        private static RMonitor rMonitor = null;

        private EUsuario usuario;
        public Reportes(EUsuario u)
        {
            InitializeComponent();
            usuario = u;

            if (usuario.Cargo != "Administrador")
            {
                btn_usuarios.Visible = false;
            }
        }

        private void btn_aula_Click(object sender, EventArgs e)
        {
            if (raula == null || raula.IsDisposed)
            {
                raula = new Raula();
                raula.Show();
            }
            else
            {
                raula.BringToFront();
            }
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            if (rcpu == null || rcpu.IsDisposed)
            {
                rcpu = new RCpu();
                rcpu.Show();
            }
            else
            {
                rcpu.BringToFront();
            }
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            if (reEquipos == null || reEquipos.IsDisposed)
            {
                reEquipos = new REquipos();
                reEquipos.Show();
            }
            else
            {
                reEquipos.BringToFront();
            }
        }

        private void btn_especialidad_Click(object sender, EventArgs e)
        {
            if (rEspecialidad == null || rEspecialidad.IsDisposed)
            {
                rEspecialidad = new REspecialidad();
                rEspecialidad.Show();
            }
            else
            {
                rEspecialidad.BringToFront();
            }
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            if (rInventario == null || rInventario.IsDisposed)
            {
                rInventario = new RInventario();
                rInventario.Show();
            }
            else
            {
                rInventario.BringToFront();
            }
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            if (rusers == null || rusers.IsDisposed)
            {
                rusers = new Rusers();
                rusers.Show();
            }
            else
            {
                rusers.BringToFront();
            }
        }

        private void btn_mobiliario_Click(object sender, EventArgs e)
        {
            if (rMobiliario == null || rMobiliario.IsDisposed)
            {
                rMobiliario = new RMobiliario();
                rMobiliario.Show();
            }
            else
            {
                rMobiliario.BringToFront();
            }
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            if (rMouse == null || rMouse.IsDisposed)
            {
                rMouse = new RMouse();
                rMouse.Show();
            }
            else
            {
                rMouse.BringToFront();
            }
        }

        private void btn_monitor_Click(object sender, EventArgs e)
        {
            if (rMonitor == null || rMonitor.IsDisposed)
            {
                rMonitor = new RMonitor();
                rMonitor.Show();
            }
            else
            {
                rMonitor.BringToFront();
            }
        }
    }
}
