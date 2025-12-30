using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Cpu : Form
    {
        private CpuControlador control;
        private List<EAula> aulas;
        private int id_selected = -1;
        public Cpu()
        {
            InitializeComponent();
            control = new CpuControlador();
            initdata();
            listarTodo();
            clean();
            cbo_aula_id.SelectedIndex = -1;
            dt_cpu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dt.Columns.Add("Procesador");
            dt.Columns.Add("RAM");
            dt.Columns.Add("ROM");
            dt.Columns.Add("Condición");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Aula");
            dt.Columns.Add("AulaId");
            dt.Columns.Add("Observaciones");

            try
            {
                List<ECpu> list = control.GetAll();
                foreach (ECpu cpu in list)
                {
                    string aulaDesc = aulas
                        .Find(a => a.Id == cpu.Aula_id)?
                        .Descripcion_aula ?? "Sin aula";

                    dt.Rows.Add(cpu.Id, cpu.Cbi, cpu.Descripcion, cpu.Marca, cpu.Modelo,
                                cpu.Serie, cpu.Procesador, cpu.Ram, cpu.Rom,
                                cpu.Condicion, cpu.Estado, aulaDesc, cpu.Aula_id, cpu.Observaciones);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error en listar: " + ex.Message;
            }
            dt_cpu.DataSource = dt;
            dt_cpu.Columns["id"].Visible = false;
            dt_cpu.Columns["AulaId"].Visible = false;
        }

        private void crearCpu()
        {
            try
            {
                ECpu cpu = new ECpu
                {
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Marca = txt_marca.Text,
                    Modelo = txt_modelo.Text,
                    Serie = txt_serie.Text,
                    Procesador = txt_procesador.Text,
                    Ram = txt_ram.Text,
                    Rom = txt_rom.Text,
                    Estado = cmb_estado.SelectedItem.ToString(),
                    Condicion = cmb_condicion.SelectedItem.ToString(),
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Observaciones = txt_observaciones.Text
                };

                int resultado = control.Create(cpu);
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
                ECpu cpu = new ECpu
                {
                    Id = id_selected,
                    Cbi = txt_cbi.Text,
                    Descripcion = txt_descripcion.Text,
                    Marca = txt_marca.Text,
                    Modelo = txt_modelo.Text,
                    Serie = txt_serie.Text,
                    Procesador = txt_procesador.Text,
                    Ram = txt_ram.Text,
                    Rom = txt_rom.Text,
                    Condicion = cmb_condicion.Text,
                    Estado = cmb_estado.Text,
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                    Observaciones = txt_observaciones.Text
                };

                control.Update(cpu);
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
                    lbl_m.Text = "Selecciona una laptop para eliminar";
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
            txt_procesador.Text = "";
            txt_ram.Text = "";
            txt_rom.Text = "";
            cmb_condicion.Text = "";
            cmb_estado.Text = "";
            cbo_aula_id.SelectedIndex = -1;
            txt_observaciones.Text = "";
        }
        private void select(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int indice = e.RowIndex;
            var fila = dt_cpu.Rows[indice];

            txt_cbi.Text = fila.Cells[1].Value.ToString();
            txt_descripcion.Text = fila.Cells[2].Value.ToString();
            txt_marca.Text = fila.Cells[3].Value.ToString();
            txt_modelo.Text = fila.Cells[4].Value.ToString();
            txt_serie.Text = fila.Cells[5].Value.ToString();
            txt_procesador.Text = fila.Cells[6].Value.ToString();
            txt_ram.Text = fila.Cells[7].Value.ToString();
            txt_rom.Text = fila.Cells[8].Value.ToString();
            cmb_condicion.Text = fila.Cells[9].Value.ToString();
            cmb_estado.Text = fila.Cells[10].Value.ToString();
            int aulaId = Convert.ToInt32(fila.Cells["AulaId"].Value);
            cbo_aula_id.SelectedValue = aulaId;
            txt_observaciones.Text = fila.Cells[13].Value.ToString();

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }
        private void dt_cpu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            crearCpu();
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
            clean();
            listarTodo();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            txt_cbi.Focus();
        }
        
    }
}
