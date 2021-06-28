namespace LeitorCSV.Model
{
    public class Candidato
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeUrna { get; set; }
        public string? NomeSocial { get; set; }
        public int Numero { get; set; }
        public string DataNascimento { get; set; }
        public long TituloEleitor { get; set; }
        public long Cpf { get; set; }
        public string Email { get; set; }
        public int IdadePosse { get; set; }
        public decimal ValorMaxCampanha { get; set; }
        public char Reeleicao { get; set; }
        public char DeclararBens { get; set; }
        public int NumeroProcesso { get; set; }

        public int EstadoID { get; set; }
        public int MunicipioID { get; set; }
        public int GeneroID { get; set; }
        public int GrauInstrucaoID { get; set; }
        public int EstadoCivilID { get; set; }
        public int CargoID { get; set; }
        public int CorRacaID { get; set; }
        public int OcupacaoID { get; set; }
        public int SituacaoPleitoID { get; set; }
        public int SituacaoCandidaturaID { get; set; }
        public int SituacaoUrnaID { get; set; }
        public int SituacaoCandidatoTurnoId { get; set; }
        public int DetalhaSituacaoCandidatoId { get; set; }
        public int PartidoId { get; set; }
        public long ColigacaoID { get; set; }
        public int NacionalidadeID { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio{ get; set; }
        public virtual Genero Genero { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual GrauInstrucao GrauInstrucao { get; set; }
        public virtual Ocupacao Ocupacao { get; set; }
        public  virtual Partido Partido { get; set; }
        public virtual SituacaoCandidatoUrna SituacaoCandidatoUrna { get; set; }
        public virtual SituacaoCandidatoPleito SituacaoCandidatoPleito { get; set; }
        public virtual SituacaoCandidatura SituacaoCandidatura { get; set; }
        public virtual SituacaoCandidatoTurno SituacaoCandidatoTurno { get; set; }
        public virtual DetalhaSituacaoCandidato DetalhaSituacaoCandidato { get; set; }
        public virtual Coligacao Coligacao{ get; set; }
        public virtual Nacionalidade Nacionalidade { get; set; }
        public virtual CorRaca CorRaca { get; set; }
    }
}
