namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class EAula
    {
        private int id;
        private string descripcion_aula;
        private string area;
        private string ancho;
        private string largo;
        private string tipo_aula;
        private string sede;
        private int especialidad_id;
        public EAula() { }
        public int Id { get => id; set => id = value; }
        public string Descripcion_aula { get => descripcion_aula; set => descripcion_aula = value; }
        public string Area { get => area; set => area = value; }
        public string Ancho { get => ancho; set => ancho = value; }
        public string Largo { get => largo; set => largo = value; }
        public string Tipo_aula { get => tipo_aula; set => tipo_aula = value; }
        public string Sede { get => sede; set => sede = value; }
        public int Especialidad_id { get => especialidad_id; set => especialidad_id = value; }
    }
}
