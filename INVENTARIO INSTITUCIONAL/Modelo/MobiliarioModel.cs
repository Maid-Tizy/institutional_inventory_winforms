using INVENTARIO_INSTITUCIONAL.Entidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class MobiliarioModel
    {
        private string tabla = "mobiliario";
        private Conexion conexion;
        public MobiliarioModel()
        {
            conexion = new Conexion();
        }
        public int Create(EMobiliario entidad)
        {
            try
            {
                string query = $"INSERT INTO {tabla} (cbi, descripcion, material, color, condicion, estado, aula_id, tipo_mobiliario, observaciones) " +
                               "VALUES (@cbi, @descripcion, @material, @color, @condicion, @estado, @aula_id, @tipo_mobiliario, @observaciones)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
                cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
                cmd.Parameters.AddWithValue("@material", entidad.Material);
                cmd.Parameters.AddWithValue("@color", entidad.Color);
                cmd.Parameters.AddWithValue("@condicion", entidad.Condicion);
                cmd.Parameters.AddWithValue("@estado", entidad.Estado);
                cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);
                cmd.Parameters.AddWithValue("@tipo_mobiliario", entidad.Tipo_mobiliario);
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
                throw new Exception("Error al crear mobiliario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<EMobiliario> ReadAll()
        {
            List<EMobiliario> list = new List<EMobiliario>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EMobiliario mobiliario = new EMobiliario
                {
                    Id = reader.GetInt32("id"),
                    Cbi = reader.GetString("cbi"),
                    Descripcion = reader.GetString("descripcion"),
                    Material = reader.GetString("material"),
                    Color = reader.GetString("color"),
                    Condicion = reader.GetString("condicion"),
                    Estado = reader.GetString("estado"),
                    Aula_id = reader.GetInt32("aula_id"),
                    Tipo_mobiliario = reader.GetString("tipo_mobiliario"),
                    Observaciones = reader.GetString("observaciones")
                };
                list.Add(mobiliario);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(EMobiliario entidad)
        {
            string query = $"UPDATE {tabla} SET cbi=@cbi, descripcion=@descripcion, material=@material, color=@color, " +
                           "condicion=@condicion, estado=@estado, aula_id=@aula_id, tipo_mobiliario=@tipo_mobiliario, observaciones=@observaciones WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
            cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("@material", entidad.Material);
            cmd.Parameters.AddWithValue("@color", entidad.Color);
            cmd.Parameters.AddWithValue("@condicion", entidad.Condicion);
            cmd.Parameters.AddWithValue("@estado", entidad.Estado);
            cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);
            cmd.Parameters.AddWithValue("@tipo_mobiliario", entidad.Tipo_mobiliario);
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
