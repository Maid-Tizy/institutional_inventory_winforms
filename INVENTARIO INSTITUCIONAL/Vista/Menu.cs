
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Menu : Form
    {
        private EUsuario usuario;
        public Menu(EUsuario u)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuario = u;
            user.Text = usuario.User;

            if (usuario.Cargo == "Administrador")
            {
                users.Visible = true;
                lbl_ad.Visible = true;
            }
            else
            {
                users.Visible = false;
                lbl_ad.Visible = false;
            }
        }

        private void btn_equipos_Click(object sender, EventArgs e)
        {
            abrirformulario(new Equipos());
        }

        private void btn_laptop_Click(object sender, EventArgs e)
        {
            abrirformulario(new Laptop());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
            
        }

        private void btn_cpu_Click(object sender, EventArgs e)
        {
            abrirformulario(new Cpu());
        }

        private void btn_monitor_Click(object sender, EventArgs e)
        {
            abrirformulario(new Monitor());
        }

        private void btn_aula_Click(object sender, EventArgs e)
        {
            abrirformulario(new Aula());

        }

        private void btn_mouse_Click(object sender, EventArgs e)
        {
            abrirformulario(new Mouse());
        }

        private void btn_teclado_Click(object sender, EventArgs e)
        {
            abrirformulario(new Teclado());
        }

        private void btn_mobiliaria_Click(object sender, EventArgs e)
        {
            abrirformulario(new Mobiliario());
        }

        private void pct_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool isMaximized = false;
        private Size originalSize;

        private void pct_maximizar_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                originalSize = this.Size;
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = originalSize;
                isMaximized = false;
            }
        }
        private void abrirformulario(Form formulario)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.Clear();
            }
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);
            formulario.Show();
        }
        private void users_Click(object sender, EventArgs e)
        {
            abrirformulario(new Usuario());
        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            abrirformulario(new Inventario());
        }

        private void btn_especialidad_Click(object sender, EventArgs e)
        {
            abrirformulario(new Especialidad());
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            abrirformulario(new Reportes(usuario));
        }
    }
}
