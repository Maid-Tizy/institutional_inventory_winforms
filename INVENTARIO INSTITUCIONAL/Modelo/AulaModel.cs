using MySql.Data.MySqlClient;
using System.Collections.Generic;
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class AulaModel
    {
        private string tabla = "aula"; 
        private Conexion conexion;

        public AulaModel()
        {
            conexion = new Conexion();
        }

        public int Create(EAula entidad)
        {
            int res = 0; 
            try
            {
                string query = $"INSERT INTO {tabla} (descripcion_aula, area, ancho, largo, tipo_aula, sede, especialidad_id) " +
                       "VALUES (@descripcion_aula, @area, @ancho, @largo, @tipo_aula, @sede, @especialidad_id)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@descripcion_aula", entidad.Descripcion_aula);
                cmd.Parameters.AddWithValue("@area", entidad.Area);
                cmd.Parameters.AddWithValue("@ancho", entidad.Ancho);
                cmd.Parameters.AddWithValue("@largo", entidad.Largo);
                cmd.Parameters.AddWithValue("@tipo_aula", entidad.Tipo_aula);
                cmd.Parameters.AddWithValue("@sede", entidad.Sede);
                cmd.Parameters.AddWithValue("@especialidad_id", entidad.Especialidad_id);

                conexion.Open();
                res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new InvalidOperationException("No se pudo insertar el registro en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear aula: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return res;
        }


        public List<EAula> ReadAll()
        {
            List<EAula> list = new List<EAula>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EAula aula = new EAula
                {
                    Id = reader.GetInt32("id"),
                    Descripcion_aula = reader.GetString("descripcion_aula"),
                    Area = reader.GetString("area"),
                    Ancho = reader.GetString("ancho"),
                    Largo = reader.GetString("largo"),
                    Tipo_aula = reader.GetString("tipo_aula"),
                    Sede = reader.GetString("sede"),
                    Especialidad_id = reader.GetInt32("especialidad_id")
                };
                list.Add(aula);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(EAula entidad)
        {
            string query = $"UPDATE {tabla} SET descripcion_aula=@descripcion_aula, area=@area, ancho=@ancho, " +
                   "largo=@largo, tipo_aula=@tipo_aula, sede=@sede, especialidad_id=@especialidad_id WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@descripcion_aula", entidad.Descripcion_aula);
            cmd.Parameters.AddWithValue("@area", entidad.Area);
            cmd.Parameters.AddWithValue("@ancho", entidad.Ancho);
            cmd.Parameters.AddWithValue("@largo", entidad.Largo);
            cmd.Parameters.AddWithValue("@tipo_aula", entidad.Tipo_aula);
            cmd.Parameters.AddWithValue("@sede", entidad.Sede);
            cmd.Parameters.AddWithValue("@especialidad_id", entidad.Especialidad_id); 
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
