
namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class ELaptop
    {
        private int id;
        private string cbi;
        private string descripcion;
        private string marca;
        private string modelo;
        private string serie;
        private string procesador;
        private string ram;
        private string rom;
        private string condicion;
        private string estado;
        private int aula_id;
        private string observaciones;

        public ELaptop() { }
        public int Id { get => id; set => id = value; }
        public string Cbi { get => cbi; set => cbi = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Serie { get => serie; set => serie = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Ram { get => ram; set => ram = value; }
        public string Rom { get => rom; set => rom = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
