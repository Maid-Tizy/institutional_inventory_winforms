using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class EspecialidadControlador
    {
        private EspecialidadModel model;

        public EspecialidadControlador()
        {
            model = new EspecialidadModel();
        }

        public int Create(EEspecialidad especialidad)
        {
            try
            {
                return model.Create(especialidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear especialidad: {ex.Message}");
                return -1;
            }
        }

        public List<EEspecialidad> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todas las especialidades: {ex.Message}");
                return new List<EEspecialidad>();
            }
        }
        public int Update(EEspecialidad especialidad)
        {
            try
            {
                return model.Update(especialidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar especialidad: {ex.Message}");
                return -1;
            }
        }
        public int Delete(int especialidadId)
        {
            try
            {
                return model.Delete(especialidadId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar especialidad: {ex.Message}");
                return -1;
            }
        }

    }
}
