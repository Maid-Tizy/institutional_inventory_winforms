using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class LaptopControlador
    {
        private LaptopModel model;

        public LaptopControlador()
        {
            model = new LaptopModel();
        }

        public int Create(ELaptop laptop)
        {
            try
            {
                return model.Create(laptop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear laptop: {ex.Message}");
                return -1;
            }
        }

        public List<ELaptop> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todas las laptops: {ex.Message}");
                return new List<ELaptop>();
            }
        }

        public int Update(ELaptop laptop)
        {
            try
            {
                return model.Update(laptop);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar laptop: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int laptopId)
        {
            try
            {
                return model.delete(laptopId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar laptop: {ex.Message}");
                return -1;
            }
        }
    }
}