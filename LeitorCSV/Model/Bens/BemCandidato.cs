namespace LeitorCSV.Model.Bens
{
    public class BemCandidato
    {
        public int Id { get; set; }
        public int numOrdemCandidato { get; set; }  // ver o que e
        public string descricao { get; set; }
        public decimal valorBem { get; set; }
        public int codigoTipoBemId { get; set; }
        public long sqCandidatoId { get; set; }
        public int estadoId { get; set; }
        public int municiopioId { get; set; }

        public virtual Candidato Candidato { get; set; }
        public virtual TipoBem TipoBem { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
    }
}
