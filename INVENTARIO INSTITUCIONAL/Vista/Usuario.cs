using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Usuario : Form
    {
        private UsuarioControlador control;
        private int id_selected = -1;
        public Usuario()
        {
            InitializeComponent();
            control = new UsuarioControlador();
            listarTodo();
            clean();
            dt_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void listarTodo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("user");
            dt.Columns.Add("password");
            dt.Columns.Add("cargo");
            try
            {
                List<EUsuario> list = control.GetAll();
                foreach (EUsuario usuario in list)
                {
                    dt.Rows.Add(usuario.Id, usuario.User, usuario.Password, usuario.Cargo);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error en listar: " + ex.Message;
            }
            dt_users.DataSource = dt;
            dt_users.Columns["id"].Visible = false;
        }

        private void crearUsuario()
        {
            try
            {
                EUsuario us = new EUsuario
                {
                    User = txt_us.Text,
                    Password = txt_pass.Text,
                    Cargo = cbo_cargo.SelectedItem?.ToString()
                };
                if (cbo_cargo.SelectedIndex == -1)
                {
                    lbl_m.Text = "Seleccione un cargo";
                }

                int resultado = control.Create(us);
                if (resultado > 0)
                {
                    lbl_m.Text = "Registro insertado correctamente";
                    clean();
                }
                else
                {
                    lbl_m.Text = "Error: No se insertó ninguna fila en la base de datos.";
                }

            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en registro: " + ex.Message;
            }
        }

        private void select(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int indice = e.RowIndex;
            var fila = dt_users.Rows[indice];
            txt_us.Text = fila.Cells[1].Value.ToString();
            txt_pass.Text = fila.Cells[2].Value.ToString();
            cbo_cargo.Text = fila.Cells[3].Value.ToString();
            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }

        private void update()
        {
            try
            {
                EUsuario us = new EUsuario
                {
                    Id = id_selected,
                    User = txt_us.Text,
                    Password = txt_pass.Text,
                    Cargo = cbo_cargo.SelectedItem?.ToString()
                };
                int resultado = control.Update(us);
                if (resultado > 0)
                {
                    lbl_m.Text = "Registro actualizado correctamente";
                    clean();
                }
                else
                {
                    lbl_m.Text = "Error: No se pudo actualizar el registro en la base de datos.";
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error en actualizar: " + ex.Message;
            }
        }
        private void delete()
        {
            try
            {
                if (id_selected != -1)
                {
                    DialogResult dialogResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        control.Delete(id_selected);
                        lbl_m.Text = "Registro eliminado correctamente";
                        clean();
                        listarTodo();
                    }
                }
                else
                {
                    lbl_m.Text = "Selecciona un aula para eliminar";
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en eliminar: " + ex.Message;
            }
        }

        private void clean()
        {
            txt_us.Text = "";
            txt_pass.Text = "";
            cbo_cargo.SelectedIndex = -1;
            id_selected = -1;
        } 
        private void dt_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_us.Focus();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            listarTodo();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            delete();
            clean();
            listarTodo();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            crearUsuario();
            listarTodo();
        }


        private void dt_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }
    }
}
