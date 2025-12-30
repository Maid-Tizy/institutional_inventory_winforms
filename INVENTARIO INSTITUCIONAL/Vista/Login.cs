using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_pass.PasswordChar = '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_us.Text;
                string password = txt_pass.Text;

                UsuarioControlador control = new UsuarioControlador();
                EUsuario usuario = control.Login(username, password);

                if (usuario != null)
                {
                    Menu menu = new Menu(usuario);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en login: " + ex.Message);
            }
        }
    }
}