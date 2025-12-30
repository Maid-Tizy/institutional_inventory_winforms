using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Equipos : Form
    {
        private EquipoControlador control;
        private int id_selected = -1;
        private List<EAula> aulas;

        public Equipos()
        {
            InitializeComponent();
            control = new EquipoControlador();
            initdata();
            listarTodo();
            clean();
            cbo_aula_id.SelectedIndex = -1;
            dt_equipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initdata()
        {
            AulaControlador ctraula = new AulaControlador();
            aulas = ctraula.GetAll();
            cbo_aula_id.DataSource = aulas;
            cbo_aula_id.DisplayMember = "descripcion_aula";
            cbo_aula_id.ValueMember = "id";
        }
        private void listarTodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CBI");
            dt.Columns.Add("Descripción");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Modelo");
            dt.Columns.Add("Serie");
            dt.Columns.Add("Condición");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Aula");
            dt.Columns.Add("AulaId");
            dt.Columns.Add("Observaciones");

            try
            {
                List<EEquipos> list = control.GetAll(); 
                foreach (EEquipos equipo in list)
                {
                    string aulaDesc = aulas
                        .Find(a => a.Id == equipo.Aula_id)?
                        .Descripcion_aula ?? "Sin aula";
                    dt.Rows.Add(equipo.Id, equipo.Cbi, equipo.Descripcion, equipo.Marca, equipo.Modelo,
                                equipo.Serie, equipo.Condicion, equipo.Estado, aulaDesc, equipo.Aula_id, equipo.Observaciones);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en listar: " + ex.Message;
            }
            dt_equipos.DataSource = dt;
            dt_equipos.Columns["id"].Visible = false;
            dt_equipos.Columns["AulaId"].Visible = false;
        }
        private void crearEquipo()
        {
            try
            {
                EEquipos equipo = new EEquipos
                {
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Marca = txt_marca.Text,
                    Modelo = txt_modelo.Text,
                    Serie = txt_serie.Text,
                    Estado = cbo_estado.SelectedItem.ToString(),
                    Condicion = cbo_condicion.SelectedItem.ToString(),
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Observaciones = txt_observaciones.Text
                };

                int resultado = control.Create(equipo);
                lbl_m.Text = "Registro insertado correctamente.";
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error en registro: " + ex.Message;
            }
        }
        private void update()
        {
            try
            {
                EEquipos equipo = new EEquipos
                {
                    Id = id_selected,
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Marca = txt_marca.Text,
                    Modelo = txt_modelo.Text,
                    Serie = txt_serie.Text,
                    Condicion = cbo_condicion.Text,
                    Estado = cbo_estado.Text,
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Observaciones = txt_observaciones.Text
                };

                control.Update(equipo);
                lbl_m.Text = "Registro actualizado correctamente";
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
                    lbl_m.Text = "Selecciona un equipo para eliminar";
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en eliminar: " + ex.Message;
            }
        }

        private void clean()
        {
            txt_cbi.Text = "";
            txt_descripcion.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_serie.Text = "";
            cbo_condicion.Text = "";
            cbo_estado.Text = "";
            cbo_aula_id.SelectedIndex = -1;
            txt_observaciones.Text = "";
        }
        private void btn_insertar_Click(object sender, EventArgs e)
        {
            crearEquipo();
            clean();
            listarTodo();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            clean();
            listarTodo();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            delete();
            listarTodo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_cbi.Focus();
        }
        private void select(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int indice = e.RowIndex;
            var fila = dt_equipos.Rows[indice];

            txt_cbi.Text = fila.Cells[1].Value.ToString();
            txt_descripcion.Text = fila.Cells[2].Value.ToString();
            txt_marca.Text = fila.Cells[3].Value.ToString();
            txt_modelo.Text = fila.Cells[4].Value.ToString();
            txt_serie.Text = fila.Cells[5].Value.ToString();
            cbo_condicion.Text = fila.Cells[6].Value.ToString();
            cbo_estado.Text = fila.Cells[7].Value.ToString();
            int aulaId = Convert.ToInt32(fila.Cells["AulaId"].Value);
            cbo_aula_id.SelectedValue = aulaId;
            txt_observaciones.Text = fila.Cells[10].Value.ToString();

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }


        private void dt_equipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }
        
    }
}
