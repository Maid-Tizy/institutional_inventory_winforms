using MySql.Data.MySqlClient;
using System.Collections.Generic;
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class EspecialidadModel
    {
        private string tabla = "especialidad";
        private Conexion conexion;

        public EspecialidadModel()
        {
            conexion = new Conexion();
        }

        public int Create(EEspecialidad entidad)
        {
            int res = 0;
            try
            {
                string query = $"INSERT INTO {tabla} (nombre, descripcion) " +
                               "VALUES (@nombre, @descripcion)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@nombre", entidad.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);

                conexion.Open();
                res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new InvalidOperationException("No se pudo insertar el registro en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear especialidad: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return res;
        }


        public List<EEspecialidad> ReadAll()
        {
            List<EEspecialidad> list = new List<EEspecialidad>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EEspecialidad especialidad = new EEspecialidad
                {
                    Id = reader.GetInt32("id"),
                    Nombre = reader.GetString("nombre"),
                    Descripcion = reader.GetString("descripcion")
                };
                list.Add(especialidad);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(EEspecialidad entidad)
        {
            string query = $"UPDATE {tabla} SET nombre=@nombre, descripcion=@descripcion WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@nombre", entidad.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("@id", entidad.Id);
            conexion.Open();
            int res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

        public int Delete(int id)
        {
            string query = $"DELETE FROM {tabla} WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            conexion.Open();
            int res = cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        }

    }
}
