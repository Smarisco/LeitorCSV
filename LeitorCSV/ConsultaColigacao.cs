using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorCSV
{
    class ConsultaColigacao
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
            public string siglaUf { get; set; }
            public string siglaUE { get; set; }
            public string nomeUE { get; set; }
            public int codigoCargo { get; set; }
            public int descricaoCargo { get; set; }
            public string tipoAgremiacao { get; set; }

            public int numPartido { get; set; }
            public string siglaPartido { get; set; }
            public string nomePartido { get; set; }
            public int seqColigacao { get; set; }
            public string nomeColigacao { get; set; }
            public string descricaoCompColigacao { get; set; }
            public string codigoSituacaoLegenda { get; set; }
            public string descSituacaoLegenda { get; set; }
        }
    }
}
