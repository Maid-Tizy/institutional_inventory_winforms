using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class AulaControlador
    {
        private AulaModel model;

        public AulaControlador()
        {
            model = new AulaModel();
        }

        public int Create(EAula aula)
        {
            try
            {
                return model.Create(aula);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear aula: {ex.Message}");
                return -1;
            }
        }

        public List<EAula> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todas las aulas: {ex.Message}");
                return new List<EAula>();
            }
        }


        public int Update(EAula aula)
        {
            try
            {
                return model.Update(aula);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar aula: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int aulaId)
        {
            try
            {
                return model.Delete(aulaId);
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Error al eliminar aula: {ex.Message}");
                return -1;
            }
        }
    }
}
