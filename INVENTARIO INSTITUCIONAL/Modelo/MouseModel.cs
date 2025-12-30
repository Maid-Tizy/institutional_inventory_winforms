using INVENTARIO_INSTITUCIONAL.Entidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class MouseModel
    {
        private string tabla = "mouse";
        private Conexion conexion;
        public MouseModel()
        {
            conexion = new Conexion();
        }
        public int Create(EMouse entidad)
        {
            try
            {
                string query = $"INSERT INTO {tabla} (codigo, descripcion, marca, modelo, serie, condicion, estado, aula_id, observaciones) " +
                               "VALUES (@codigo, @descripcion, @marca, @modelo, @serie, @condicion, @estado, @aula_id, @observaciones)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@codigo", entidad.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
                cmd.Parameters.AddWithValue("@marca", entidad.Marca);
                cmd.Parameters.AddWithValue("@modelo", entidad.Modelo);
                cmd.Parameters.AddWithValue("@serie", entidad.Serie);
                cmd.Parameters.AddWithValue("@condicion", entidad.Condicion);
                cmd.Parameters.AddWithValue("@estado", entidad.Estado);
                cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);
                cmd.Parameters.AddWithValue("@observaciones", entidad.Observaciones);

                conexion.Open();
                int res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new InvalidOperationException("No se pudo insertar el registro en la base de datos.");
                }

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear mouse: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<EMouse> ReadAll()
        {
            List<EMouse> list = new List<EMouse>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EMouse mouse = new EMouse
                {
                    Id = reader.GetInt32("id"),
                    Codigo = reader.GetString("codigo"),
                    Descripcion = reader.GetString("descripcion"),
                    Marca = reader.GetString("marca"),
                    Modelo = reader.GetString("modelo"),
                    Serie = reader.GetString("serie"),
                    Condicion = reader.GetString("condicion"),
                    Estado = reader.GetString("estado"),
                    Aula_id = reader.GetInt32("aula_id"),
                    Observaciones = reader.GetString("observaciones")
                };
                list.Add(mouse);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(EMouse entidad)
        {
            string query = $"UPDATE {tabla} SET codigo=@codigo, descripcion=@descripcion, marca=@marca, modelo=@modelo, " +
                           "serie=@serie, condicion=@condicion, " +
                           "estado=@estado, aula_id=@aula_id, observaciones=@observaciones WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@codigo", entidad.Codigo);
            cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("@marca", entidad.Marca);
            cmd.Parameters.AddWithValue("@modelo", entidad.Modelo);
            cmd.Parameters.AddWithValue("@serie", entidad.Serie);
            cmd.Parameters.AddWithValue("@condicion", entidad.Condicion);
            cmd.Parameters.AddWithValue("@estado", entidad.Estado);
            cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);
            cmd.Parameters.AddWithValue("@observaciones", entidad.Observaciones);
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

