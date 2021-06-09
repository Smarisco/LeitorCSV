using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorCSV
{
    class ConsultaCandidato
    {
        public DateTime datGeracao { get; set; }
        public DateTime horaGeracao { get; set; }
        public int anoEleicao { get; set; }

        public int cdTipo { get; set; }
        public string NomeTipoEleicao { get; set; }
        public int turnoEleicao { get; set; }
        public int codigoEleicao { get; set; }
        public string dsEleicao { get; set; }

        public DateTime dataEleicao { get; set; }
        public string tipoAbrangência { get; set; }
        public string siglaUE { get; set; }
        public string nomeUE { get; set; }
        public int codigoCargo { get; set; }
        public int descricaoCargo { get; set; }
        public int sqCandidato { get; set; }
        public int numCandidato { get; set; }
        public string nomeCandidato { get; set; }
        public string nomeUrna { get; set; }
        public string nomeSocial { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public int codigoSituacao { get; set; }
        public string descricaoSituacao { get; set; }
        public int codigoDetalheSituacao { get; set; }
        public string descricaoDetalheSituacao { get; set; }
        public string tipoAgremiacao { get; set; }
        public int numPartido { get; set; }
        public string siglaPartido { get; set; }
        public string nomePartido { get; set; }
        public int seqColigacao { get; set; }
        public string nomeColigacao { get; set; }
        public string descricaoCompColigacao { get; set; }
        public int codigoNacionalidade { get; set; }
        public string descricaoNacionalidade { get; set; }
        public string siglaUfNascimento { get; set; }
        public int codMunicipioNascimento { get; set; }
        public string nomeMunicipioNasc { get; set; }

        public DateTime dataNascimento { get; set; }

        public int idade { get; set; }
        public int numTituloEleitor { get; set; }
        public int codigoGenero { get; set; }
        public string descGenero { get; set; }
        public int codigoEnsino { get; set; }
        public string descEnsino { get; set; }
        public int codigoEstadoCivil { get; set; }
        public string estadoCivil { get; set; }
        public int codigoRaca { get; set; }
        public string descricaoRaca { get; set; }
        public int codigoOcupacao { get; set; }
        public string descOcupacao { get; set; }
        public double valorDespesa { get; set; }
        public int codSitTotTurno { get; set; }
        public string descSitTotTurno { get; set; }
        public bool stReelicao { get; set; }
        public bool stDeclaraBenas { get; set; }
        public int numProtocoloCandidatura { get; set; }
        public string numeroProcesso { get; set; }
        public string descricaoSituacaoPleito { get; set; }
        public int codigoSitucao { get; set; }
        public string descricaoSituacaoUrna { get; set; }
        public string situacaoCandidatoUrna { get; set; }
    }
}
