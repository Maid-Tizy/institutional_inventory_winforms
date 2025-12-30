using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    internal class MonitorControlador
    {
        private MonitorModel model;

        public MonitorControlador()
        {
            model = new MonitorModel();
        }

        public int Create(EMonitor monitor)
        {
            try
            {
                return model.Create(monitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear monitor: {ex.Message}");
                return -1;
            }
        }

        public List<EMonitor> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los monitores: {ex.Message}");
                return new List<EMonitor>();
            }
        }

        public int Update(EMonitor monitor)
        {
            try
            {
                return model.Update(monitor);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar monitor: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int monitorId)
        {
            try
            {
                return model.Delete(monitorId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar monitor: {ex.Message}");
                return -1;
            }
        }
    }
}