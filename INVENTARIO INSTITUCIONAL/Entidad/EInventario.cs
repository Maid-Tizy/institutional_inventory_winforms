
namespace INVENTARIO_INSTITUCIONAL.Entidad
{
    public class EInventario
    {
        private int id;
        private string cbi;
        private string tipo_item;
        private string inv_anterior;
        private string inv_actual;
        private string observaciones;
        private int aula_id;
        public EInventario() { }
        public int Id { get => id; set => id = value; }
        public string Cbi { get => cbi; set => cbi = value; }
        public string Tipo_item { get => tipo_item; set => tipo_item = value; }
        public string Inv_anterior { get => inv_anterior; set => inv_anterior = value; }
        public string Inv_actual { get => inv_actual; set => inv_actual = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
    }
}
