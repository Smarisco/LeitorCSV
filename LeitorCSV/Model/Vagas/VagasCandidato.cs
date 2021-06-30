namespace LeitorCSV.Model.Vagas
{
    public class VagasCandidato
    {
        public int Id { get; set; }
        public string DataPosse{ get; set; }
        public string DataEleicao{ get; set; }
        public int QtdeVagas { get; set; }
        public int EstadoID { get; set; }
        public int MunicipioId { get; set; }
        public int CargoID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }

        public virtual Cargo Cargo{ get; set; }
    }
}
