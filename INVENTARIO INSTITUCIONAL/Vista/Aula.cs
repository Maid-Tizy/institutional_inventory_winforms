using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Controlador;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Aula : Form
    {
        private AulaControlador control;
        private int id_selected = -1;

        public Aula()
        {
            InitializeComponent();
            CargarEspecialidades();
            control = new AulaControlador();
            listarTodo();
            clean();
            dt_aulas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txt_area.KeyDown += Txt_area_KeyDown;
        }
        private void CargarEspecialidades()
        {
            try
            {
                EspecialidadControlador especialidadCtrl = new EspecialidadControlador();
                List<EEspecialidad> list = especialidadCtrl.GetAll();

                cbo_especialidad.DataSource = list;
                cbo_especialidad.DisplayMember = "Nombre"; 
                cbo_especialidad.ValueMember = "Id";     
                cbo_especialidad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error al cargar especialidades: " + ex.Message;
            }
        }

        private void listarTodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Área");
            dt.Columns.Add("Ancho");
            dt.Columns.Add("Largo");
            dt.Columns.Add("Tipo Aula");
            dt.Columns.Add("Sede");
            dt.Columns.Add("Especialidad");

            try
            {
                List<EAula> list = control.GetAll();
                foreach (EAula aula in list)
                {
                    dt.Rows.Add(aula.Id, aula.Descripcion_aula, aula.Area, aula.Ancho, aula.Largo, aula.Tipo_aula, aula.Sede, aula.Especialidad_id);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error en listar: " + ex.Message;
            }
            dt_aulas.DataSource = dt;
            dt_aulas.Columns["id"].Visible = false;
        }

        private void crearAula()
        {
            try
            {
                EAula aula = new EAula
                {
                    Descripcion_aula = txt_descripcion.Text,
                    Area = txt_area.Text,
                    Ancho = txt_ancho.Text,
                    Largo = txt_largo.Text,
                    Tipo_aula = cbo_tipo_aula.SelectedItem.ToString(),
                    Sede = cbo_sede.SelectedItem.ToString(),
                    Especialidad_id = (int)cbo_especialidad.SelectedValue 
                };

                int resultado = control.Create(aula);
                if (resultado > 0)
                {
                    lbl_m.Text = "Registro insertado correctamente";
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
            var fila = dt_aulas.Rows[indice];
            txt_descripcion.Text = fila.Cells[1].Value.ToString();
            txt_area.Text = fila.Cells[2].Value.ToString();
            txt_ancho.Text = fila.Cells[3].Value.ToString();
            txt_largo.Text = fila.Cells[4].Value.ToString();
            cbo_tipo_aula.Text = fila.Cells[5].Value.ToString();
            cbo_sede.Text = fila.Cells[6].Value.ToString();
            cbo_especialidad.Text = fila.Cells[7].Value.ToString();
            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }

        private void update()
        {
            try
            {
                EAula aula = new EAula
                {
                    Id = id_selected,
                    Descripcion_aula = txt_descripcion.Text,
                    Area = txt_area.Text,
                    Ancho = txt_ancho.Text,
                    Largo = txt_largo.Text,
                    Tipo_aula = cbo_tipo_aula.Text,
                    Sede = cbo_sede.Text,
                    Especialidad_id = (int)cbo_especialidad.SelectedValue
                };

                int resultado = control.Update(aula);
                if (resultado > 0)
                {
                    lbl_m.Text = "Registro actualizado correctamente";
                }
                else
                {
                    lbl_m.Text = "Error: No se pudo actualizar el registro en la base de datos.";
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en actualizar: " + ex.Message;
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
            txt_descripcion.Text = "";
            txt_area.Text = "";
            txt_ancho.Text = "";
            txt_largo.Text = "";
            cbo_tipo_aula.Text = "";
            cbo_sede.Text = "";
            cbo_especialidad.SelectedIndex = -1;
        }

        private void Txt_area_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    double area = double.Parse(txt_area.Text);

                    double ancho = Math.Sqrt(area * 2 / 3);
                    double largo = 1.5 * ancho;
                    txt_ancho.Text = ancho.ToString("F2");
                    txt_largo.Text = largo.ToString("F2");
                }
                catch (FormatException)
                {
                    lbl_m.Text = "Ingrese un número válido en el campo Área.";
                }
                catch (Exception ex)
                {
                    lbl_m.Text = "Error al calcular: " + ex.Message;
                }

                e.Handled = true;
            }
        }

        private void pct_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_descripcion.Focus();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            delete();
            listarTodo();
        }

        private void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            update();
            clean();
            listarTodo();
        }

        private void btn_insertar_Click_1(object sender, EventArgs e)
        {
            crearAula();
            clean();
            listarTodo();
        }

        private void dt_aulas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }
        
    }
}
