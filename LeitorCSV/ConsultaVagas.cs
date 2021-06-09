using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorCSV
{
    class ConsultaVagas
    {
        public DateTime datGeracao { get; set; }
        public DateTime horaGeracao { get; set; }
        public int anoEleicao { get; set; }

        public int cdTipo { get; set; }
        public string NomeTipoEleicao { get; set; }
        public int codigoEleicao { get; set; }
        public string dsEleicao { get; set; }
        public DateTime dataEleicao { get; set; }
        public DateTime dataPosse { get; set; }
        public string siglaUf { get; set; }
        public string siglaUE { get; set; }
        public string nomeUE { get; set; }
        public int codigoCargo { get; set; }
        public int descricaoCargo { get; set; }
        public int qtdVagas { get; set; }
    }
}
