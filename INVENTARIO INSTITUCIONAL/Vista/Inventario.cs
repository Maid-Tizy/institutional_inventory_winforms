using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Controlador;
using INVENTARIO_INSTITUCIONAL.Vista.Reporte;

namespace INVENTARIO_INSTITUCIONAL.Vista
{
    public partial class Inventario : Form
    {
        private InventarioControlador control;
        private int id_selected = -1;
        private List<EAula> aulas;
        public Inventario()
        {
            InitializeComponent();
            control = new InventarioControlador();
            initdata();
            listarTodo();
            clean();
            dt_inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cbo_item.SelectedIndexChanged += cbo_item_SelectedIndexChanged;

        }
        private void initdata()
        {
            AulaControlador ctraula = new AulaControlador();
            aulas = ctraula.GetAll();
            cbo_aula_id.DataSource = aulas;
            cbo_aula_id.DisplayMember = "descripcion_aula";
            cbo_aula_id.ValueMember = "id";
        }
        private void cbo_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_cbi.DataSource = null;

            if (cbo_item.Text == "Cpu")
            {
                CpuControlador controlCpu = new CpuControlador();
                var listaCpu = controlCpu.GetAll();
                cbo_cbi.DataSource = listaCpu;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else if (cbo_item.Text == "Equipo")
            {
                EquipoControlador controlEquipos = new EquipoControlador();
                var listaEquipos = controlEquipos.GetAll();
                cbo_cbi.DataSource = listaEquipos;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else if (cbo_item.Text == "Laptop")
            {
                LaptopControlador controlLaptop = new LaptopControlador();
                var listaLaptop = controlLaptop.GetAll();
                cbo_cbi.DataSource = listaLaptop;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else if (cbo_item.Text == "Mobiliario")
            {
                MobiliarioControlador controlMobiliario = new MobiliarioControlador();
                var listaMobiliario = controlMobiliario.GetAll();
                cbo_cbi.DataSource = listaMobiliario;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else if (cbo_item.Text == "Monitor")
            {
                MonitorControlador controlMonitor = new MonitorControlador();
                var listaMonitor = controlMonitor.GetAll();
                cbo_cbi.DataSource = listaMonitor;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else if (cbo_item.Text == "Mouse")
            {
                MouseControlador controlMouse = new MouseControlador();
                var listaMouse = controlMouse.GetAll();
                cbo_cbi.DataSource = listaMouse;
                cbo_cbi.DisplayMember = "Codigo";
                cbo_cbi.ValueMember = "Codigo";
            }
            else if (cbo_item.Text == "Teclado")
            {
                TecladoControlador controlTeclado = new TecladoControlador();
                var listaTeclado = controlTeclado.GetAll();
                cbo_cbi.DataSource = listaTeclado;
                cbo_cbi.DisplayMember = "Cbi";
                cbo_cbi.ValueMember = "Cbi";
            }
            else
            {
                cbo_cbi.DataSource = null;
            }
        }
        private void listarTodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("CBI");
            dt.Columns.Add("Tipo de Item");
            dt.Columns.Add("Inventario Anterior");
            dt.Columns.Add("Inventario Actual");
            dt.Columns.Add("Observaciones");
            dt.Columns.Add("Aula");
            dt.Columns.Add("AulaId");

            try
            {
                List<EInventario> list = control.GetAll();
                foreach (EInventario inventario in list)
                {
                    string aulaDesc = aulas
                        .Find(a => a.Id == inventario.Aula_id)?
                        .Descripcion_aula ?? "Sin aula"; 

                    dt.Rows.Add(inventario.Id, inventario.Cbi, inventario.Tipo_item, inventario.Inv_anterior,
                                inventario.Inv_actual, inventario.Observaciones,aulaDesc, inventario.Aula_id);
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text = "Error al listar: " + ex.Message;
            }
            dt_inventario.DataSource = dt;
            dt_inventario.Columns["id"].Visible = false;
            dt_inventario.Columns["AulaId"].Visible = false;
        }

        private void crearInventario()
        {
            try
            {
               
                EInventario inventario = new EInventario
                {
                    Cbi = cbo_cbi.Text,
                    Tipo_item = cbo_item.SelectedItem.ToString(),
                    Inv_anterior = txt_invant.Text,
                    Inv_actual = txt_invact.Text,
                    Observaciones = txt_observaciones.Text,
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue),
                };

                int resultado = control.Create(inventario);
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
                lbl_m.Text = "Error en registro: " + ex.Message;
            }
        }

        private void select(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int indice = e.RowIndex;
            var fila = dt_inventario.Rows[indice];

            cbo_item.SelectedItem = fila.Cells[2].Value.ToString();
            cbo_cbi.SelectedValue = fila.Cells[1].Value.ToString();
            txt_invant.Text = fila.Cells[3].Value.ToString();
            txt_invact.Text = fila.Cells[4].Value.ToString();
            txt_observaciones.Text = fila.Cells[5].Value.ToString();
            cbo_aula_id.SelectedValue = Convert.ToInt32(fila.Cells["AulaId"].Value);

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());
        }


        private void update()
        {
            try
            {
                EInventario inventario = new EInventario
                {
                    Id = id_selected,
                    Cbi = cbo_cbi.SelectedValue.ToString(),  // <- usar SelectedValue
                    Tipo_item = cbo_item.SelectedItem.ToString(),
                    Inv_anterior = txt_invant.Text,
                    Inv_actual = txt_invact.Text,
                    Observaciones = txt_observaciones.Text,
                    Aula_id = Convert.ToInt32(cbo_aula_id.SelectedValue)
                };
                int resultado = control.Update(inventario);

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
                lbl_m.Text += "Error al actualizar: " + ex.Message;
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
                    lbl_m.Text = "Selecciona un inventario para eliminar";
                }
            }
            catch (Exception ex)
            {
                lbl_m.Text += "Error al eliminar: " + ex.Message;
            }
        }

        private void clean()
        {
            cbo_cbi.SelectedIndex = -1;
            cbo_item.SelectedIndex = -1;
            cbo_aula_id.SelectedIndex = -1;
            txt_invant.Text = "";
            txt_invact.Text = "";
            txt_observaciones.Text = "";
        }

        private void dt_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select(e);
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            crearInventario();
            clean();
            listarTodo();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            update();
            clean();
            listarTodo();
        }

        private void btn_nuevo_Click_1(object sender, EventArgs e)
        {
            clean();
            lbl_m.Text = "Inserte un nuevo registro";
            cbo_cbi.Focus();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            delete();
            listarTodo();
        }
    }
}
