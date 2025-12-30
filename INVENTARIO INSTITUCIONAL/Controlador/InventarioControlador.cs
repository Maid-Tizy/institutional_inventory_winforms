using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class InventarioControlador
    {
        private InventarioModel model;

        public InventarioControlador()
        {
            model = new InventarioModel();
        }
        public int Create(EInventario inventario)
        {
            try
            {
                return model.Create(inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear inventario: {ex.Message}" + ex.StackTrace);
                return -1;
            }
        }
        public List<EInventario> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los inventarios: {ex.Message}" + ex.StackTrace);
                return new List<EInventario>();
            }
        }
        public int Update(EInventario inventario)
        {
            try
            {
                return model.Update(inventario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar inventario: {ex.Message}" + ex.StackTrace);
                return -1;
            }
        }
        public int Delete(int inventarioId)
        {
            try
            {
                return model.Delete(inventarioId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar inventario: {ex.Message}" + ex.StackTrace);
                return -1;
            }
        }
    }
}

