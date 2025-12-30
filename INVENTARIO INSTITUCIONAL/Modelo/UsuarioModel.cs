using INVENTARIO_INSTITUCIONAL.Entidad;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class UsuarioModel
    {
        private string tabla = "control";
        private Conexion conexion;

        public UsuarioModel()
        {
            conexion = new Conexion();
        }

        public int Create(EUsuario entidad)
        {
            int res = 0;
            try
            {
                string query = $"INSERT INTO {tabla} (user, password, cargo) " +
                               "VALUES (@user, @password, @cargo)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@user", entidad.User);
                cmd.Parameters.AddWithValue("@password", entidad.Password);
                cmd.Parameters.AddWithValue("@cargo", entidad.Cargo);
                conexion.Open();
                res = cmd.ExecuteNonQuery();

                if (res == 0)
                {
                    throw new InvalidOperationException("No se pudo insertar el registro en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear usuario: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return res;
        }


        public List<EUsuario> ReadAll()
        {
            List<EUsuario> list = new List<EUsuario>();
            string query = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EUsuario aula = new EUsuario
                {
                    Id = reader.GetInt32("id"),
                    User = reader.GetString("user"),
                    Password = reader.GetString("password"),
                    Cargo = reader.GetString("cargo")
                };
                list.Add(aula);
            }
            reader.Close();
            conexion.Close();
            return list;
        }

        public int Update(EUsuario entidad)
        {
            string query = $"UPDATE {tabla} SET user=@user, password=@password, cargo=@cargo WHERE id=@id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@user", entidad.User);
            cmd.Parameters.AddWithValue("@password", entidad.Password);
            cmd.Parameters.AddWithValue("@cargo", entidad.Cargo);
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
        public EUsuario Login(string user, string password)
        {
            EUsuario entidad = null;

            string query = $"SELECT * FROM control WHERE user=@user AND password=@password LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@password", password);

            conexion.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                entidad = new EUsuario
                {
                    Id = reader.GetInt32("id"),
                    User = reader.GetString("user"),
                    Password = reader.GetString("password"),
                    Cargo = reader.GetString("cargo")
                };
            }

            reader.Close();
            conexion.Close();

            return entidad;
        }

    }
}