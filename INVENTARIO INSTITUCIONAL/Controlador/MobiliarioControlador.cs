using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    internal class MobiliarioControlador
    {
        private MobiliarioModel model;

        public MobiliarioControlador()
        {
            model = new MobiliarioModel();
        }

        public int Create(EMobiliario mobiliario)
        {
            try
            {
                return model.Create(mobiliario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear mobiliario: {ex.Message}");
                return -1;
            }
        }

        public List<EMobiliario> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los mobiliarios: {ex.Message}");
                return new List<EMobiliario>();
            }
        }

        public int Update(EMobiliario mobiliario)
        {
            try
            {
                return model.Update(mobiliario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar mobiliario: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int mobiliarioId)
        {
            try
            {
                return model.Delete(mobiliarioId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar mobiliario: {ex.Message}");
                return -1;
            }
        }
    }
}
