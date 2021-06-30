using LeitorCSV.Model;
using LeitorCSV.Model.Bens;
using LeitorCSV.Model.Vagas;
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
                var teste = LeituraDados();

                //    List<Candidato> candidatos = LeituraDadosCandidatos();

                //    LeituraBens();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private static IEnumerable<string> ObterArquivos(string caminhoDaPasta)
        {
            var arquivos = Directory.EnumerateFiles(caminhoDaPasta, "*.csv");

            return arquivos;
        }

        public static List<Candidato> LeituraDados()
        {
            var arquivosCandidato = ObterArquivos(@"C:\Users\solpe\Desktop\LDB\consulta_cand_2020");

            var listaCargos = new List<Cargo>();
            var listaMunicipo = new List<Municipio>();
            var listaEstado = new List<Estado>();
            var listaPartido = new List<Partido>();
            var listaColigacao = new List<Coligacao>();
            var listaGenero = new List<Genero>();
            var listaGrauEnsino = new List<GrauInstrucao>();
            var listaEstadoCivil = new List<EstadoCivil>();
            var listaCorRaca = new List<CorRaca>();
            var listaOcupacao = new List<Ocupacao>();
            var listaSituCandidatura = new List<SituacaoCandidatura>();
            var listaPleito = new List<SituacaoCandidatoPleito>();
            var listaUrna = new List<SituacaoCandidatoUrna>();
            var listaDetalhaSituacao = new List<DetalhaSituacaoCandidato>();
            var listaNascionalidade = new List<Nacionalidade>();
            var listaSituCandidatoTurno = new List<SituacaoCandidatoTurno>();
            var listaCandidatura = new List<Candidatura>();
            var listaCandidatos = new List<Candidato>();


            foreach (var arquivo in arquivosCandidato)
            {
                using (var reader = new StreamReader(arquivo))
                {
                    bool cabecalhoLinha = true;

                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var valores = linha.Split(';');

                        if (cabecalhoLinha)
                        {
                            cabecalhoLinha = false;
                            continue;
                        }

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
                        candidato.IdadePosse = Convert.ToInt32(RegexString(valores[39]));
                        candidato.TituloEleitor = Convert.ToInt64(RegexString(valores[40]));
                        candidato.ValorMaxCampanha = Convert.ToDecimal(RegexString(valores[51])); /// ver isso
                        candidato.Reeleicao = Convert.ToChar(RegexString(valores[54]).ToString());
                        candidato.DeclararBens = Convert.ToChar(RegexString(valores[55]));

                        var estado = new Estado(); /// id autoincrement
                        estado.Sigla = RegexString(valores[10]).ToString();

                        candidato.EstadoID = estado.Id;
                        candidato.Estado = estado;
                        if (listaEstado.Exists(x => x.Sigla.Equals(estado.Sigla)) == false)
                        {
                            listaEstado.Add(estado);
                        }

                        var municipio = new Municipio();
                        municipio.Id = Convert.ToInt32(RegexString(valores[11]));
                        municipio.Nome = RegexString(valores[12]).ToString();
                        municipio.EstadoID = estado.Id;
                        municipio.Estado = estado;

                        candidato.MunicipioID = municipio.Id;
                        candidato.Municipio = municipio;

                        if (listaMunicipo.Exists(x => x.Id == municipio.Id) == false)
                        {
                            listaMunicipo.Add(municipio);
                        }

                        var cargo = new Cargo();
                        cargo.Id = Convert.ToInt32(RegexString(valores[13]));
                        cargo.Descricao = RegexString(valores[14]).ToString();

                        candidato.CargoID = cargo.Id;
                        candidato.Cargo = cargo;

                        if (listaCargos.Exists(x => x.Id == cargo.Id) == false)
                        {
                            listaCargos.Add(cargo);
                        }

                        var situCandidatura = new SituacaoCandidatura();
                        situCandidatura.Id = Convert.ToInt32(RegexString(valores[22]));
                        situCandidatura.Descricao = RegexString(valores[23]).ToString();

                        candidato.SituacaoCandidaturaID = situCandidatura.Id;
                        candidato.SituacaoCandidatura = situCandidatura;

                        if (listaSituCandidatura.Exists(x => x.Id == situCandidatura.Id) == false)
                        {
                            listaSituCandidatura.Add(situCandidatura);
                        }

                        var detalhaSituacao = new DetalhaSituacaoCandidato();
                        detalhaSituacao.Id = Convert.ToInt32(RegexString(valores[24]));
                        detalhaSituacao.Descricao = RegexString(valores[25]).ToString();
                        candidato.SituacaoCandidaturaID = situCandidatura.Id;
                        candidato.SituacaoCandidatura = situCandidatura;

                        if (listaDetalhaSituacao.Exists(x => x.Id == detalhaSituacao.Id) == false)
                        {
                            listaSituCandidatura.Add(situCandidatura);
                        }

                        var partido = new Partido();
                        partido.TipoAgremiacao = RegexString(valores[26]).ToString();
                        partido.Id = Convert.ToInt32(RegexString(valores[27]));
                        partido.Sigla = RegexString(valores[28]).ToString();
                        partido.Nome = RegexString(valores[29]).ToString();

                        candidato.PartidoId = partido.Id;
                        candidato.Partido = partido;

                        if (listaPartido.Exists(x => x.Id == partido.Id) == false)
                        {
                            listaPartido.Add(partido);
                        }

                        var coligacao = new Coligacao();
                        coligacao.Id = Convert.ToInt64(RegexString(valores[30]));
                        coligacao.Nome = RegexString(valores[31]).ToString();
                        coligacao.Composicao = RegexString(valores[32]).ToString();

                        candidato.ColigacaoID = coligacao.Id;
                        candidato.Coligacao = coligacao;

                        if (listaColigacao.Exists(x => x.Id == coligacao.Id) == false)
                        {
                            listaColigacao.Add(coligacao);
                        }

                        var nascionalidade = new Nacionalidade();
                        nascionalidade.Id = Convert.ToInt32(RegexString(valores[33]));
                        nascionalidade.Descricao = RegexString(valores[34]).ToString();

                        candidato.NacionalidadeID = nascionalidade.Id;
                        candidato.Nacionalidade = nascionalidade;

                        if (listaNascionalidade.Exists(x => x.Id == nascionalidade.Id) == false)
                        {
                            listaNascionalidade.Add(nascionalidade);
                        }

                        var genero = new Genero();
                        genero.Id = Convert.ToInt32(RegexString(valores[41]));
                        genero.Descricao = RegexString(valores[42]).ToString();

                        candidato.GeneroID = genero.Id;
                        candidato.Genero = genero;

                        if (listaGenero.Exists(x => x.Id == genero.Id))
                        {
                            listaGenero.Add(genero);
                        }

                        var grauEnsino = new GrauInstrucao();
                        grauEnsino.Id = Convert.ToInt32(RegexString(valores[43]));
                        grauEnsino.Descricao = RegexString(valores[44]).ToString();

                        candidato.GrauInstrucaoID = grauEnsino.Id;
                        candidato.GrauInstrucao = grauEnsino;

                        if (listaGrauEnsino.Exists(x => x.Id == grauEnsino.Id) == false)
                        {
                            listaGrauEnsino.Add(grauEnsino);
                        }

                        var estadoCivil = new EstadoCivil();
                        estadoCivil.Id = Convert.ToInt32(RegexString(valores[45]));
                        estadoCivil.Descricao = RegexString(valores[46]).ToString();

                        candidato.EstadoCivilID = estadoCivil.Id;
                        candidato.EstadoCivil = estadoCivil;

                        if (listaEstadoCivil.Exists(x => x.Id == estadoCivil.Id) == false)
                        {
                            listaEstadoCivil.Add(estadoCivil);
                        }

                        var raca = new CorRaca();
                        raca.ID = Convert.ToInt32(RegexString(valores[47]));
                        raca.Descricao = RegexString(valores[48]).ToString();

                        candidato.CorRacaID = raca.ID;
                        candidato.CorRaca = raca;

                        if (listaCorRaca.Exists(x => x.ID == raca.ID) == false)
                        {
                            listaCorRaca.Add(raca);
                        }

                        var ocupacao = new Ocupacao();
                        ocupacao.Id = Convert.ToInt32(RegexString(valores[49]));
                        ocupacao.Descricao = RegexString(valores[50]).ToString();

                        candidato.OcupacaoID = ocupacao.Id;
                        candidato.Ocupacao = ocupacao;

                        if (listaOcupacao.Exists(x => x.Id == ocupacao.Id) == false)
                        {
                            listaOcupacao.Add(ocupacao);
                        }

                        var situTurno = new SituacaoCandidatoTurno();
                        situTurno.Id = Convert.ToInt32(RegexString(valores[52]));
                        situTurno.Descricao = RegexString(valores[53]).ToString();

                        candidato.SituacaoCandidatoTurnoId = situTurno.Id;
                        candidato.SituacaoCandidatoTurno = situTurno;

                        if (listaSituCandidatoTurno.Exists(x => x.Id == situTurno.Id) == false)
                        {
                            listaSituCandidatoTurno.Add(situTurno);
                        }

                        var candidatura = new Candidatura();
                        candidatura.NumeroProtocolo = Convert.ToInt64(RegexString(valores[57]));
                        candidatura.InseridoUrna = RegexString(valores[62]).ToString();

                        candidato.SituacaoCandidaturaID = candidatura.Id;
                        candidato.Candidatura = candidatura;

                        if (listaCandidatura.Exists(x => x.Id == candidatura.Id) == false)
                        {
                            listaCandidatura.Add(candidatura);
                        }

                        var situPleito = new SituacaoCandidatoPleito();
                        situPleito.Id = Convert.ToInt32(RegexString(valores[58]));
                        situPleito.Descricao = RegexString(valores[59]).ToString();

                        candidato.SituacaoPleitoID = situPleito.Id;
                        candidato.SituacaoCandidatoPleito = situPleito;

                        if (listaPleito.Exists(x => x.Id == situPleito.Id) == false)
                        {
                            listaPleito.Add(situPleito);
                        }

                        var situUrna = new SituacaoCandidatoUrna();
                        situUrna.Id = Convert.ToInt32(RegexString(valores[60]));
                        situUrna.Descricao = RegexString(valores[61]).ToString();

                        candidato.SituacaoUrnaID = situUrna.Id;
                        candidato.SituacaoCandidatoUrna = situUrna;

                        if (listaUrna.Exists(x => x.Id == situUrna.Id) == false)
                        {
                            listaUrna.Add(situUrna);
                        }

                        listaCandidatos.Add(candidato);
                    }
                }
            }

            var listaBens = LeituraBens(listaEstado, listaMunicipo);
            var listaVagas = LeituraVagas(listaEstado, listaMunicipo);

            return listaCandidatos;
        }

        private static List<BemCandidato> LeituraBens(List<Estado> listaEstados, List<Municipio> listaMunicipios)
        {
            var arquivos = ObterArquivos(@"C:\Users\solpe\Desktop\LDB\bem_candidato_2020");

            var listaBens = new List<BemCandidato>();
            var listaTipoBem = new List<TipoBem>();

            foreach (var arquivo in arquivos)
            {
                using (var reader = new StreamReader(arquivo))
                {
                    bool cabecalhoLinha = true;

                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var valores = linha.Split(';');

                        if (cabecalhoLinha)
                        {
                            cabecalhoLinha = false;
                            continue;
                        }

                        var bemCandidato = new BemCandidato();

                        var estado = new Estado();
                        estado.Sigla = RegexString(valores[8]).ToString();

                        var municipio = new Municipio();
                        municipio.Id = Convert.ToInt32(RegexString(valores[9]));
                        municipio.Nome = RegexString(valores[10]).ToString();
                        municipio.EstadoID = estado.Id;
                        municipio.Estado = estado;

                        bemCandidato.estadoId = estado.Id;
                        bemCandidato.Estado = estado;
                        bemCandidato.municiopioId = municipio.Id;
                        bemCandidato.Municipio = municipio;

                        if (listaEstados.Exists(x => x.Sigla.Equals(estado.Sigla)) == false)
                        {
                            listaEstados.Add(estado);
                        }

                        if (listaMunicipios.Exists(x => x.Id == municipio.Id) == false)
                        {
                            listaMunicipios.Add(municipio);
                        }

                        var tipoBem = new TipoBem();
                        tipoBem.Id = Convert.ToInt32(RegexString(valores[13]));
                        tipoBem.Descricao = RegexString(valores[14]).ToString();

                        bemCandidato.codigoTipoBemId = tipoBem.Id;
                        bemCandidato.TipoBem = tipoBem;
                        if (listaTipoBem.Exists(x => x.Id.Equals(tipoBem.Id)) == false)
                        {
                            listaTipoBem.Add(tipoBem);
                        }

                        bemCandidato.sqCandidatoId = Convert.ToInt64(RegexString(valores[11]));
                        bemCandidato.numOrdemCandidato = Convert.ToInt32(RegexString(valores[12]));
                        bemCandidato.descricao = RegexString(valores[15]).ToString();
                        bemCandidato.valorBem = Convert.ToInt32(RegexString(valores[16]));

                        listaBens.Add(bemCandidato);
                        ///ver se ja vai salvar aqui ou nao
                    }
                }
            }

            return listaBens;
        }

        private static List<VagasCandidato> LeituraVagas(List<Estado> estados, List<Municipio> municipios)
        {
            var arquivos = ObterArquivos(@"C:\Users\solpe\Desktop\LDB\consulta_vagas_2020");

            var listaCargos = new List<Cargo>();
            var listaVagas = new List<VagasCandidato>();

            foreach (var arquivo in arquivos)
            {
                using (var reader = new StreamReader(arquivo))
                {
                    bool cabecalhoLinha = true;

                    while (!reader.EndOfStream)
                    {
                        var linha = reader.ReadLine();
                        var valores = linha.Split(';');

                        if (cabecalhoLinha)
                        {
                            cabecalhoLinha = false;
                            continue;
                        }

                        var vagaCandidato = new VagasCandidato();

                        var estado = new Estado();
                        estado.Sigla = RegexString(valores[9]).ToString();

                        var municipio = new Municipio();
                        municipio.Id = Convert.ToInt32(RegexString(valores[10]));
                        municipio.Nome = RegexString(valores[11]).ToString();
                        municipio.EstadoID = estado.Id;
                        municipio.Estado = estado;


                        if (estados.Exists(x => x.Sigla.Equals(estado.Sigla)) == false)
                        {
                            estados.Add(estado);
                        }

                        if (municipios.Exists(x => x.Id == municipio.Id) == false)
                        {
                            municipios.Add(municipio);
                        }

                        var cargo = new Cargo();
                        cargo.Id = Convert.ToInt32(RegexString(valores[12]));
                        cargo.Descricao = RegexString(valores[13]).ToString();


                        if (listaCargos.Exists(x => x.Id.Equals(cargo.Id)) == false)
                        {
                            listaCargos.Add(cargo);
                        }

                        vagaCandidato.DataEleicao = RegexString(valores[7]).ToString();
                        vagaCandidato.DataPosse = RegexString(valores[8]).ToString();
                        vagaCandidato.QtdeVagas = Convert.ToInt32(RegexString(valores[14]));
                        vagaCandidato.EstadoID = estado.Id;
                        vagaCandidato.Estado = estado;

                        vagaCandidato.MunicipioId = municipio.Id;
                        vagaCandidato.Municipio = municipio;

                        vagaCandidato.CargoID = cargo.Id;
                        vagaCandidato.Cargo = cargo;

                        listaVagas.Add(vagaCandidato);
                    }
                }
            }

            return listaVagas;
        }

        private static void LeituraColigacao()
        {

        }

        private static void LeituraCassacao()
        {

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