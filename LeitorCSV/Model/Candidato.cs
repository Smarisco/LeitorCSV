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
        public long TituloEleitor{ get; set; }
        public long Cpf { get; set; }
        public string Email { get; set; }
        public int IdadePosse { get; set; }
        public decimal ValorMaxCampanha { get; set; }
        public char Reeleicao { get; set; }
        public char DeclararBens{ get; set; }
        public int NumeroProcesso { get; set; }

        public int GeneroID { get; set; }
        public int GrauInstrucaoID { get; set; }
        public int EstadoCivilID { get; set; }
        public int CorRacaID { get; set; }
        public int OcupacaoID { get; set; }
        public int SituacaoPleito { get; set; }
        public int SituacaoUrna{ get; set; }
        public int MunicipioNascimentoID{ get; set; }


        public virtual Municipio Municipio{ get; set; }
        public virtual Genero Genero { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual GrauInstrucao GrauInstrucao { get; set; }
        public virtual Ocupacao Ocupacao { get; set; }
        public virtual SituacaoCandidatoUrna SituacaoCandidatoUrna{ get; set; }
        public virtual SituacaoCandidatoPleito SituacaoCandidatoPleito { get; set; }

    }
}
