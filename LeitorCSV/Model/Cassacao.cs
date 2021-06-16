namespace LeitorCSV.Model
{
    public class Cassacao
    {
        public int Id { get; set; }
        public int Motivo { get; set; }
        public int CandidatoID { get; set; }

        public virtual Candidato Candidato { get; set; }
    }
}
