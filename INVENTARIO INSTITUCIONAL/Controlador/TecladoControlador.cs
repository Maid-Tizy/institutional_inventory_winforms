using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    internal class TecladoControlador
    {
        private TecladoModel model;

        public TecladoControlador()
        {
            model = new TecladoModel();
        }

        public int Create(ETeclado teclado)
        {
            try
            {
                return model.Create(teclado);
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"Error al crear teclado: {ex.Message}");
                return -1;
            }
        }

        public List<ETeclado> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los teclados: {ex.Message}");
                return new List<ETeclado>();
            }
        }

        public int Update(ETeclado teclado)
        {
            try
            {
                return model.Update(teclado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar teclado: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int tecladoId)
        {
            try
            {
                return model.Delete(tecladoId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar teclado: {ex.Message}");
                return -1;
            }
        }
    }
}
