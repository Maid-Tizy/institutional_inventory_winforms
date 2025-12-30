using MySql.Data.MySqlClient;

namespace INVENTARIO_INSTITUCIONAL.Modelo
{
    internal class Conexion
    {
        private string server = "localhost";
        private string db_name = "inventario";
        private string db_user = "root";
        private string db_pass = "Arroz123";

        private MySqlConnection conn;
        public MySqlConnection getConexion { get => conn; }

        public Conexion()
        {
            string connectionString = $"Server={server};database={db_name};User ID={db_user};Password={db_pass};SslMode=none;";
            conn = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
