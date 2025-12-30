using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    internal class MouseControlador
    {
        private MouseModel model;

        public MouseControlador()
        {
            model = new MouseModel();
        }

        public int Create(EMouse mouse)
        {
            try
            {
                return model.Create(mouse);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear mouse: {ex.Message}");
                return -1;
            }
        }

        public List<EMouse> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los mouses: {ex.Message}");
                return new List<EMouse>();
            }
        }

        public int Update(EMouse mouse)
        {
            try
            {
                return model.Update(mouse);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar mouse: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int mouseId)
        {
            try
            {
                return model.Delete(mouseId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar mouse: {ex.Message}");
                return -1;
            }
        }
    }
}
