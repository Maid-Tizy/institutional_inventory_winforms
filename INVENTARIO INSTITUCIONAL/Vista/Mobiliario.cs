using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Mobiliario : Form
    {
        private MobiliarioControlador control;
        private int id_selected = -1;
        private List<EAula> aulas;

        public Mobiliario()
        {
            InitializeComponent();
            control = new MobiliarioControlador();
            initdata();
            listarTodo();
            clean();
            cbo_aula_id.SelectedIndex = -1;
            dt_mobiliario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dt.Columns.Add("Material");
            dt.Columns.Add("Color");
            dt.Columns.Add("Condición");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Aula");
            dt.Columns.Add("AulaId");
            dt.Columns.Add("Tipo Mobiliario");
            dt.Columns.Add("Observaciones");

            try
            {
                List<EMobiliario> list = control.GetAll();
                foreach (EMobiliario mobiliario in list)
                {
                    string aulaDesc = aulas
                        .Find(a => a.Id == mobiliario.Aula_id)?
                        .Descripcion_aula ?? "Sin aula";

                    dt.Rows.Add(
                        mobiliario.Id,
                        mobiliario.Cbi,
                        mobiliario.Descripcion,
                        mobiliario.Material,
                        mobiliario.Color,
                        mobiliario.Condicion,
                        mobiliario.Estado,
                        aulaDesc,              
                        mobiliario.Aula_id,    
                        mobiliario.Tipo_mobiliario,
                        mobiliario.Observaciones
                    );
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en listar: " + ex.Message;
            }

            dt_mobiliario.DataSource = dt;
            dt_mobiliario.Columns["ID"].Visible = false;
            dt_mobiliario.Columns["AulaId"].Visible = false; 
        }




        private void crearMobiliario()
        {
            try
            {
                EMobiliario mobiliario = new EMobiliario
                {
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Material = txt_material.Text,
                    Color = txt_color.Text,
                    Estado = cbo_estado.SelectedItem.ToString(),
                    Condicion = cbo_condicion.SelectedItem.ToString(),
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Tipo_mobiliario = txt_tipo.Text,
                    Observaciones = txt_observaciones.Text
                };

                int resultado = control.Create(mobiliario);
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
                EMobiliario mobiliario = new EMobiliario
                {
                    Id = id_selected,
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Material = txt_material.Text,
                    Color = txt_color.Text,
                    Estado = cbo_estado.SelectedItem.ToString(),
                    Condicion = cbo_condicion.SelectedItem.ToString(),
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Tipo_mobiliario = txt_tipo.Text,
                    Observaciones = txt_observaciones.Text
                    
                };
                control.Update(mobiliario);
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
            txt_material.Text = "";
            txt_color.Text = "";
            cbo_condicion.SelectedIndex = -1;
            cbo_estado.SelectedIndex = -1;
            cbo_aula_id.SelectedIndex = -1;
            txt_tipo.Text = "";
            txt_observaciones.Text = "";
        }
        private void select(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int indice = e.RowIndex;
            var fila = dt_mobiliario.Rows[indice];

            txt_cbi.Text = fila.Cells[1].Value.ToString();
            txt_descripcion.Text = fila.Cells[2].Value.ToString();
            txt_material.Text = fila.Cells[3].Value.ToString();
            txt_color.Text = fila.Cells[4].Value.ToString();
            cbo_condicion.Text = fila.Cells[5].Value.ToString();
            cbo_estado.Text = fila.Cells[6].Value.ToString();
            int aulaId = Convert.ToInt32(fila.Cells["AulaId"].Value);
            cbo_aula_id.SelectedValue = aulaId;
            txt_tipo.Text = fila.Cells[9].Value.ToString();
            txt_observaciones.Text = fila.Cells[10].Value.ToString();

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            crearMobiliario();
            clean();
            listarTodo();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            clean();
            listarTodo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_cbi.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            delete();
            clean();
            listarTodo();
        }

        private void dt_mobiliario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }
        

    }
}
