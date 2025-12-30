using MySql.Data.MySqlClient;
using System.Collections.Generic;
using INVENTARIO_INSTITUCIONAL.Entidad;
using System;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class LaptopModel
    {
        private string tabla = "laptop";
        private Conexion conexion;

        public LaptopModel()
        {
            conexion = new Conexion();
        }

        public int Create(ELaptop entidad)
        {
            try
            {
                string query = $"INSERT INTO {tabla} (cbi, descripcion, marca, modelo, serie, procesador, ram, rom, condicion, estado, aula_id, observaciones) " +
                               "VALUES (@cbi, @descripcion, @marca, @modelo, @serie, @procesador, @ram, @rom, @condicion, @estado, @aula_id, @observaciones)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
                cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
                cmd.Parameters.AddWithValue("@marca", entidad.Marca);
                cmd.Parameters.AddWithValue("@modelo", entidad.Modelo);
                cmd.Parameters.AddWithValue("@serie", entidad.Serie);
                cmd.Parameters.AddWithValue("@procesador", entidad.Procesador);
                cmd.Parameters.AddWithValue("@ram", entidad.Ram);
                cmd.Parameters.AddWithValue("@rom", entidad.Rom);
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
                throw new Exception("Error al crear laptop: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public List<ELaptop> ReadAll()
        {
            List<ELaptop> list = new List<ELaptop>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ELaptop laptop = new ELaptop
                {
                    Id = reader.GetInt32("id"),
                    Cbi = reader.GetString("cbi"),
                    Descripcion = reader.GetString("descripcion"),
                    Marca = reader.GetString("marca"),
                    Modelo = reader.GetString("modelo"),
                    Serie = reader.GetString("serie"),
                    Procesador = reader.GetString("procesador"),
                    Ram = reader.GetString("ram"),
                    Rom = reader.GetString("rom"),
                    Condicion = reader.GetString("condicion"),
                    Estado = reader.GetString("estado"),
                    Aula_id = reader.GetInt32("aula_id"),
                    Observaciones = reader.GetString("observaciones")
                };
                list.Add(laptop);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(ELaptop entidad)
        {
            string query = $"UPDATE {tabla} SET cbi=@cbi, descripcion=@descripcion, marca=@marca, modelo=@modelo, " +
                           "serie=@serie, procesador=@procesador, ram=@ram, rom=@rom, condicion=@condicion, " +
                           "estado=@estado, aula_id=@aula_id, observaciones=@observaciones WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@cbi", entidad.Cbi);
            cmd.Parameters.AddWithValue("@descripcion", entidad.Descripcion);
            cmd.Parameters.AddWithValue("@marca", entidad.Marca);
            cmd.Parameters.AddWithValue("@modelo", entidad.Modelo);
            cmd.Parameters.AddWithValue("@serie", entidad.Serie);
            cmd.Parameters.AddWithValue("@procesador", entidad.Procesador);
            cmd.Parameters.AddWithValue("@ram", entidad.Ram);
            cmd.Parameters.AddWithValue("@rom", entidad.Rom);
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

        public int delete(int id)
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
