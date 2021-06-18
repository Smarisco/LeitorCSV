# LeitorCSV
TrabalhoLbd

Banco Dados Postgresql

create table candidato(
	id integer,
	numero integer,
	nome varchar (255),
	nomeUrna varchar(255),
	nomeSocial varchar (255),
	cpf varchar (11),
	--alterar codigo string
	email varchar (255),
	valorMaxCampanha decimal,
	reeleicao char,
	declraBens char,
	numeroProcesso integer,
	inseridoUrna char,
	generoId integer,
	grauInstrucaoId integer,
	estadoCivilId integer,
	corRacaId integer,
	ocupacaoId integer,
	situacaoPleitoId integer,
	situacaoUrnaId integer
		
)

ALTER TABLE "candidato" ADD PRIMARY KEY (id)

ALTER TABLE "candidato"
ADD CONSTRAINT generoId_constraint FOREIGN KEY (generoId) REFERENCES genero(id);

ALTER TABLE "candidato"
ADD CONSTRAINT grauInstrucaoId_constraint FOREIGN KEY (grauInstrucaoId) REFERENCES grauinstrucao(id);

ALTER TABLE "candidato"
ADD CONSTRAINT estadoCivilId_constraint FOREIGN KEY (estadoCivilId) REFERENCES estadocivil(id);

ALTER TABLE "candidato"
ADD CONSTRAINT corRacaId_constraint FOREIGN KEY (corRacaId) REFERENCES corraca(id);

ALTER TABLE "candidato"
ADD CONSTRAINT ocupacaoId_constraint FOREIGN KEY (ocupacaoId) REFERENCES ocupacao(id);

ALTER TABLE "candidato"
ADD CONSTRAINT situacaoPleitoId_constraint FOREIGN KEY (situacaoPleitoId) REFERENCES situacaocandidatopleito(id);

ALTER TABLE "candidato"
ADD CONSTRAINT situacaoUrnaId_constraint FOREIGN KEY (situacaoUrnaId) REFERENCES situacaocandidatourna(id);

create table cargo(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "cargo" ADD PRIMARY KEY (id)

create table cassacao(
	id integer,
	motivo integer,
	candidatoId integer
)

ALTER TABLE "cassacao" ADD PRIMARY KEY (id)

ALTER TABLE "cassacao"
ADD CONSTRAINT candidatoId_constraint FOREIGN KEY (candidatoId) REFERENCES candidato(id);

create table coligacao(
	id integer,
	nome varchar (255),
	composicao varchar (255),
	situacao varchar (255),
	descricaoLegenda integer
)

ALTER TABLE "coligacao" ADD PRIMARY KEY (id)

create table corRaca(
id integer,
descricao varchar (255)
)

ALTER TABLE "corraca" ADD PRIMARY KEY (id)

create table estado(
id integer,
	sigla varchar (10)
)

ALTER TABLE "estado" ADD PRIMARY KEY (id)

create table estadoCivil(
id integer,
	descricao varchar (255)
)

ALTER TABLE "estadocivil" ADD PRIMARY KEY (id)

create table genero(
id integer,
	descricao varchar (255)
)
ALTER TABLE "genero" ADD PRIMARY KEY (id)

create table grauInstrucao(
id integer,
	descricao varchar (255)
)

ALTER TABLE "grauinstrucao" ADD PRIMARY KEY (id)

create table municipios(
id integer,
	nome varchar (255),
	estadoId integer
)

ALTER TABLE "municipios" ADD PRIMARY KEY (id)

ALTER TABLE "municipios"
ADD CONSTRAINT estadoId_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);

create table ocupacao(
id integer,
	descricao varchar (255)
)

ALTER TABLE "ocupacao" ADD PRIMARY KEY (id)

create table partido(
id integer,
	nome varchar (255),
	sigla varchar(10),
	tipoAgremiacao varchar (255)
)

ALTER TABLE "partido" ADD PRIMARY KEY (id)

create table situacaoCandidatoPleito(
id integer,
	descricao varchar (255)
)

ALTER TABLE "situacaocandidatopleito" ADD PRIMARY KEY (id)

create table situacaoCandidatoUrna(
id integer,
	descricao varchar (255)
)

ALTER TABLE "situacaocandidatourna" ADD PRIMARY KEY (id)








