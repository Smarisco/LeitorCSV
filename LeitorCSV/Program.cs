using LeitorCSV.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace LeitorCSV
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var arquivos = ObterArquivos();

                LeituraArquivoCSV(arquivos);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static IEnumerable<string> ObterArquivos()
        {
            var caminhoDaPasta = @"C:\Users\scandido\Desktop\Samara\facul\LBD\Eleicao\consulta_cand_2020";
            var arquivos = Directory.EnumerateFiles(caminhoDaPasta, "*.csv");

            return arquivos;
        }

        public static void LeituraArquivoCSV(IEnumerable<string> arquivos)
        {
            bool cabecalhoLinha = true;
            var listaCargos = new List<Cargo>();
            var listaMunicipo = new List<Municipio>();
            var listaEstado = new List<Estado>();
            var listaPartido = new List<Partido>();
            var listaColigacao = new List<Coligacao>();
            var listaGenenro = new List<Genero>();
            var listaGrauEnsino = new List<GrauInstrucao>();
            var listaSituCivil = new List<EstadoCivil>();
            var listaCorRaca = new List<CorRaca>();
            var listaOcupacao = new List<Ocupacao>();

            var listaPleito = new List<SituacaoCandidatoPleito>();
            var listaUrna = new List<SituacaoCandidatoUrna>();



            foreach (var arquivo in arquivos)
            {
                using (var reader = new StreamReader(arquivo))
                {
                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var valores = linha.Split(';');

                        if (cabecalhoLinha)
                        {
                            cabecalhoLinha = false;
                            continue;
                        }
                        var estado = new Estado(); /// id autoincrement
                        estado.Sigla = RegexString(valores[10]).ToString();
                        listaEstado.Add(estado);

                        var municipio = new Municipio();
                        municipio.Id = Convert.ToInt32(RegexString(valores[11]));
                        municipio.Nome = RegexString(valores[12]).ToString();
                        municipio.Estado = estado;
                        listaMunicipo.Add(municipio);

                        var cargo = new Cargo();
                        cargo.Id = Convert.ToInt32(RegexString(valores[13]));
                        cargo.Descricao = RegexString(valores[14]).ToString();
                        listaCargos.Add(cargo);

                        //add candidato
                        var situCandidato = new SituacaoCandidatura();
                        situCandidato.Id = Convert.ToInt32(RegexString(valores[22]));
                        situCandidato.Descricao = RegexString(valores[23]).ToString();

                        // add candidato
                        var detalhaSitu = new DetalhaSituacaoCandidato();
                        detalhaSitu.Id = Convert.ToInt32(RegexString(valores[24]));
                        detalhaSitu.Descricao = RegexString(valores[25]).ToString();

                        var partido = new Partido();
                        partido.TipoAgremiacao = RegexString(valores[26]).ToString();
                        partido.Id = Convert.ToInt32(RegexString(valores[27]));
                        partido.Sigla = RegexString(valores[28]).ToString();
                        partido.Nome = RegexString(valores[29]).ToString();


                        var coligacao = new Coligacao();
                        coligacao.Id = Convert.ToInt64(RegexString(valores[30])); // trocar pra long
                        coligacao.Nome = RegexString(valores[31]).ToString();
                        coligacao.Composicao = RegexString(valores[32]).ToString();

                        //add candidato
                        var nacionalidade = new Nacionalidade();
                        nacionalidade.Id = Convert.ToInt32(RegexString(valores[33]));
                        nacionalidade.Descricao = RegexString(valores[34]).ToString();

                        var genero = new Genero();
                        genero.Id = Convert.ToInt32(RegexString(valores[41]));
                        genero.Descricao = RegexString(valores[42]).ToString();

                        var grauEnsino = new GrauInstrucao();
                        grauEnsino.Id = Convert.ToInt32(RegexString(valores[43]));
                        grauEnsino.Descricao = RegexString(valores[44]).ToString();

                        var estadoCivil = new EstadoCivil();
                        estadoCivil.Id = Convert.ToInt32(RegexString(valores[45]));
                        estadoCivil.Descricao = RegexString(valores[46]).ToString();

                        var raca = new CorRaca();
                        raca.ID = Convert.ToInt32(RegexString(valores[47]));
                        raca.Descricao = RegexString(valores[48]).ToString();

                        var ocupacao = new Ocupacao();
                        ocupacao.Id = Convert.ToInt32(RegexString(valores[49]));
                        ocupacao.Descricao = RegexString(valores[50]).ToString();

                        var situTurno = new SituacaoCandidatoTurno();
                        situTurno.Id = Convert.ToInt32(RegexString(valores[52]));
                        situTurno.Descricao = RegexString(valores[53]).ToString();

                        var candidatura = new Candidatura();
                        candidatura.NumeroProtocolo = Convert.ToInt64(RegexString(valores[57]));
                        candidatura.InseridoUrna = RegexString(valores[62]).ToString();

                        var situPleito = new SituacaoCandidatoPleito();
                        situCandidato.Id = Convert.ToInt32(RegexString(valores[58]));
                        situCandidato.Descricao = RegexString(valores[59]).ToString();

                        var situUrna = new SituacaoCandidatoUrna();
                        situUrna.Id = Convert.ToInt32(RegexString(valores[60]));
                        situUrna.Descricao = RegexString(valores[61]).ToString();


                        var candidato = new Candidato();
                        candidato.Id = Convert.ToInt64(RegexString(valores[15]));
                        candidato.Numero = Convert.ToInt32(RegexString(valores[16]));
                        candidato.Nome = RegexString(valores[17]).ToString();
                        candidato.NomeUrna = RegexString(valores[18]).ToString();
                        candidato.NomeSocial = RegexString(valores[19]).ToString() == "NULO" ? null : RegexString(valores[20]).ToString();
                        candidato.Cpf = Convert.ToInt64(RegexString(valores[20]));
                        candidato.Email = RegexString(valores[21]).ToString();
                        candidato.IdadePosse = Convert.ToInt32(RegexString(valores[39]));
                        /// ver como adicionar dados nascimento,junto do municipio
                        candidato.DataNascimento = RegexString(valores[38]).ToString();
                        /// adicionar idade posse 39
                        candidato.TituloEleitor = Convert.ToInt64(RegexString(valores[40]));
                        candidato.ValorMaxCampanha = Convert.ToDecimal(RegexString(valores[51]));
                        candidato.Reeleicao = Convert.ToChar(RegexString(valores[54]).ToString());
                        candidato.DeclararBens = Convert.ToChar(RegexString(valores[55]));

                    }

                }
            }
        }

        private static string RegexString(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters,
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return String.Empty;
            }

        }
    }
}

