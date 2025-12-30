using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class CpuControlador
    {
        private CpuModel model;

        public CpuControlador()
        {
            model = new CpuModel();
        }

        public int Create(ECpu cpu)
        {
            try
            {
                return model.Create(cpu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear cpu: {ex.Message}");
                return -1;
            }
        }

        public List<ECpu> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todas las cpu: {ex.Message}");
                return new List<ECpu>();
            }
        }

        public int Update(ECpu cpu)
        {
            try
            {
                return model.Update(cpu);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar cpu: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int cpuId)
        {
            try
            {
                return model.delete(cpuId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar cpu: {ex.Message}");
                return -1;
            }
        }
    }
}