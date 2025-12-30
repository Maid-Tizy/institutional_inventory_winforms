using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using INVENTARIO_INSTITUCIONAL.Entidad;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class InventarioModel
    {
        private string tabla = "inventario";
        private Conexion conexion;

        public InventarioModel()
        {
            conexion = new Conexion();
        }
        public int Create(EInventario entidad)
        {
            int res = 0;
            try
            {
                string query = $"INSERT INTO {tabla} (cbi, tipo_item, inv_anterior, inv_actual, observaciones, aula_id) " +
                               "VALUES (@cbi, @tipo_item, @inv_anterior, @inv_actual, @observaciones, @aula_id)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
                cmd.Parameters.AddWithValue("@tipo_item", entidad.Tipo_item);
                cmd.Parameters.AddWithValue("@inv_anterior", entidad.Inv_anterior);
                cmd.Parameters.AddWithValue("@inv_actual", entidad.Inv_actual);
                cmd.Parameters.AddWithValue("@observaciones", entidad.Observaciones);
                cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);

                conexion.Open();
                res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new InvalidOperationException("No se pudo insertar el registro en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return res;
        }
        public List<EInventario> ReadAll()
        {
            List<EInventario> list = new List<EInventario>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EInventario inventario = new EInventario
                {
                    Id = reader.GetInt32("id"),
                    Cbi = reader.GetString("cbi"),
                    Tipo_item = reader.GetString("tipo_item"),
                    Inv_anterior = reader.GetString("inv_anterior"),
                    Inv_actual = reader.GetString("inv_actual"),
                    Observaciones = reader.GetString("observaciones"),
                    Aula_id = reader.GetInt32("aula_id")
                };
                list.Add(inventario);
            }
            reader.Close();
            conexion.Close();
            return list;
        }
        public int Update(EInventario entidad)
        {
            string query = $"UPDATE {tabla} SET cbi=@cbi, tipo_item=@tipo_item, inv_anterior=@inv_anterior, " +
                           "inv_actual=@inv_actual, observaciones=@observaciones, aula_id=@aula_id WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
            cmd.Parameters.AddWithValue("@tipo_item", entidad.Tipo_item);
            cmd.Parameters.AddWithValue("@inv_anterior", entidad.Inv_anterior);
            cmd.Parameters.AddWithValue("@inv_actual", entidad.Inv_actual);
            cmd.Parameters.AddWithValue("@observaciones", entidad.Observaciones);
            cmd.Parameters.AddWithValue("@aula_id", entidad.Aula_id);
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
