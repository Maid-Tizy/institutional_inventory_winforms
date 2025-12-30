using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Especialidad : Form
    {
        private EspecialidadControlador control;
        private int id_selected = -1;
        public Especialidad()
        {
            InitializeComponent();
            control = new EspecialidadControlador();
            listarTodo();
            clean();
            dt_especialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void listarTodo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            dt.Columns.Add("descripcion");
            try
            {
                List<EEspecialidad> list = control.GetAll();
                foreach (EEspecialidad especialidad in list)
                {
                    dt.Rows.Add(especialidad.Id, especialidad.Nombre, especialidad.Descripcion);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error en listar: " + ex.Message;
            }
            dt_especialidad.DataSource = dt;
            dt_especialidad.Columns["id"].Visible = false;
        }

        private void crear()
        {
            try
            {
                EEspecialidad us = new EEspecialidad
                {
                    Nombre = txt_nombre.Text,
                    Descripcion = txt_descripcion.Text,
                };

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
            var fila = dt_especialidad.Rows[indice];
            txt_nombre.Text = fila.Cells[1].Value.ToString();
            txt_descripcion.Text = fila.Cells[2].Value.ToString();
            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }

        private void update()
        {
            try
            {
                EEspecialidad us = new EEspecialidad
                {
                    Id = id_selected,
                    Nombre = txt_nombre.Text,
                    Descripcion = txt_descripcion.Text,
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
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
            id_selected = -1;
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            crear();
            listarTodo();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            listarTodo();
        }

        private void dt_especialidad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_nombre.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            delete();
            clean();
            listarTodo();
        }
    }
}
