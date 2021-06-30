namespace LeitorCSV.Model
{
    public class Coligacao
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Composicao { get; set; }
        public string SituacaoLegenda { get; set; }
        public int DescricaoLegenda { get; set; }
        public string Agremiacao { get; set; }
        public int CargoID { get; set; }
        public int PartidoId { get; set; }
        public int EstadoId{ get; set; }
        public int MunicipioId { get; set; }

        public virtual Cargo  Cargo { get; set; }
        public virtual Estado Estado{ get; set; }
        public virtual Municipio Municipio{ get; set; }
        public virtual Partido Partido{ get; set; }


    }
}
