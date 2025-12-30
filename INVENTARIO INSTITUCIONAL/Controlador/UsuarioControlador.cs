using INVENTARIO_INSTITUCIONAL.Entidad;
using INVENTARIO_INSTITUCIONAL.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace INVENTARIO_INSTITUCIONAL.Controlador
{
    public class UsuarioControlador
    {
        private UsuarioModel model;

        public UsuarioControlador()
        {
            model = new UsuarioModel();
        }
        public EUsuario Login(string username, string password)
        {
            try
            {
                return model.Login(username, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta de login: " + ex.Message);
            }
        }

        public int Create(EUsuario usuario)
        {
            try
            {
                return model.Create(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear usuario: {ex.Message}");
                return -1;
            }
        }

        public List<EUsuario> GetAll()
        {
            try
            {
                return model.ReadAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener todos los usuarios: {ex.Message}");
                return new List<EUsuario>();
            }
        }

        public int Update(EUsuario usuario)
        {
            try
            {
                return model.Update(usuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar usuario: {ex.Message}");
                return -1;
            }
        }

        public int Delete(int usuarioId)
        {
            try
            {
                return model.Delete(usuarioId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar usuario: {ex.Message}");
                return -1;
            }
        }

    }
}
