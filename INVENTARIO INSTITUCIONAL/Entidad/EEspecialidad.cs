namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class EEspecialidad
    {
        private int id;
        private string nombre;
        private string descripcion;

        public EEspecialidad() { }
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
