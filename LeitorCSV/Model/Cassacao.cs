namespace LeitorCSV.Model
{
    public class Cassacao
    {
        public int Id { get; set; }
        public string Motivo { get; set; }
        public long CandidatoID { get; set; }
        public int EstadoID { get; set; }
        public int MunicipioId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual Candidato Candidato { get; set; }
    }
}
