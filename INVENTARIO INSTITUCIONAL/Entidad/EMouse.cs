namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class EMouse
    {
        private int id;
        private string codigo;
        private string descripcion;
        private string marca;
        private string modelo;
        private string serie;
        private string condicion;
        private string estado;
        private int aula_id;
        private string observaciones;
        public EMouse() { }

        public int Id { get => id; set => id = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Serie { get => serie; set => serie = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
    }
}
