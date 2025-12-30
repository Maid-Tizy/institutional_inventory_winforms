namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class EUsuario
    {
        private int id;
        private string user;
        private string password;
        private string cargo;
        public EUsuario() { }
        public int Id { get => id; set => id = value; }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
