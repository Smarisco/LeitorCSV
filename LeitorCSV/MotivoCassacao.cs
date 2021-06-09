using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorCSV
{
    class MotivoCassacao
    {
        public DateTime datGeracao { get; set; }
        public DateTime horaGeracao { get; set; }
        public int anoEleicao { get; set; }

        public int cdTipo { get; set; }
        public string NomeTipoEleicao { get; set; }
        public int codigoEleicao { get; set; }
        public string dsEleicao { get; set; }
        public string siglaUf { get; set; }
        public string siglaUE { get; set; }
        public int sqCandidato  { get; set; }
        public string motivoCassacao { get; set; }

    }
}
