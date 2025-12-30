using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System;
using INVENTARIO_INSTITUCIONAL.Vista;
using System.Windows.Forms;
namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class EquipoControlador
    {
        private EquiposModel model;

        public EquipoControlador()
        {
            model = new EquiposModel();
        }

        public int Create(EEquipos equipo)
        {
            try
            {
                return model.Create(equipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear equipo: {ex.Message}");
                return -1;
            }
        }

        public List<EEquipos> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los equipos: {ex.Message}");
                return new List<EEquipos>();
            }
        }

        public int Update(EEquipos equipo)
        {
            try
            {
                return model.Update(equipo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar equipo: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int equipoId)
        {
            try
            {
                return model.Delete(equipoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar equipo: {ex.Message}");
                return -1;
            }
        }
    }
}