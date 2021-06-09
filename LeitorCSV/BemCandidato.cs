using System;
using System.Collections.Generic;
using System.Text;

namespace LeitorCSV
{
    class BemCandidato
    {
        public DateTime datGeracao { get; set; }
        public DateTime horaGeracao { get; set; }
        public int anoEleicao { get; set; }

        public int cdTipo { get; set; }
        public string NomeTipoEleicao { get; set; }
        public int codigoEleicao { get; set; }
        public string dsEleicao { get; set; }

        public DateTime dataEleicao { get; set; }
        public string siglaUE { get; set; }
        public string nomeUE { get; set; }
        public int sqCandidato { get; set; }
        public int numOrdemCandidato { get; set; }
        public int codigoTipoBem  { get; set; }
        public string descricaoTipoBem  { get; set; }
        public int valorBem { get; set; }
        public DateTime dataUltimaAtualizacao { get; set; }
        public DateTime horaUltimaAtualizacao { get; set; }
    }
}
