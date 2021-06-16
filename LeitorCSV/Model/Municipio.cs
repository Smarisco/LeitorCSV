namespace LeitorCSV.Model
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EstadoID { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
