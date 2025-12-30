namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    internal class EMobiliario
    {
        private int id;
        private string cbi;
        private string descripcion;
        private string material;
        private string color;
        private string condicion;
        private string estado;
        private int aula_id;
        private string tipo_mobiliario;
        private string observaciones;
        public EMobiliario() { }

        public int Id { get => id; set => id = value; }
        public string Cbi { get => cbi; set => cbi = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Material { get => material; set => material = value; }
        public string Color { get => color; set => color = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Tipo_mobiliario { get => tipo_mobiliario; set => tipo_mobiliario = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
