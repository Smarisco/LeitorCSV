

create table candidato(
	id bigint,
	nome varchar (255),
	nomeUrna varchar(255),
	nomeSocial varchar (255),
	numero integer,
	dataNascimento varchar(8),
	tituloEleitor bigint,
	cpf varchar (11),
	email varchar (255),
	idadePosse integer,
	valorMaxCampanha decimal,
	reeleicao char,
	declararBens char,
	numeroProcesso integer,

	estadoId integer,
	municipioId integer,
	generoId integer,
	grauInstrucaoId integer,
	estadoCivilId integer,
	cargoId integer,
	corRacaId integer,
	ocupacaoId integer,
	situacaoPleitoId integer,
	situacaoCandidaturaId integer,
	situacaoUrnaId integer,
	situacaoCandidatoTurnoId integer,
	detalhaSituacaoCandidatoId integer,
	partidoId integer,
	coligacaoId bigint,
	nacionalidadeId integer
		
)

ALTER TABLE "candidato" ADD PRIMARY KEY (id)

ALTER TABLE "candidato"
ADD CONSTRAINT estado_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);

ALTER TABLE "candidato"
ADD CONSTRAINT municipioId_constraint FOREIGN KEY (municipioId) REFERENCES municipio(id);

ALTER TABLE "candidato"
ADD CONSTRAINT generoId_constraint FOREIGN KEY (generoId) REFERENCES genero(id);

ALTER TABLE "candidato"
ADD CONSTRAINT grauInstrucaoId_constraint FOREIGN KEY (grauInstrucaoId) REFERENCES grauinstrucao(id);

ALTER TABLE "candidato"
ADD CONSTRAINT estadoCivilId_constraint FOREIGN KEY (estadoCivilId) REFERENCES estadocivil(id);


ALTER TABLE "candidato"
ADD CONSTRAINT cargoId_constraint FOREIGN KEY (cargoId) REFERENCES cargo(id);

ALTER TABLE "candidato"
ADD CONSTRAINT corRacaId_constraint FOREIGN KEY (corRacaId) REFERENCES corraca(id);

ALTER TABLE "candidato"
ADD CONSTRAINT ocupacaoId_constraint FOREIGN KEY (ocupacaoId) REFERENCES ocupacao(id);

ALTER TABLE "candidato"
ADD CONSTRAINT situacaoPleitoId_constraint FOREIGN KEY (situacaoPleitoId) REFERENCES situacaocandidatopleito(id);


ALTER TABLE "candidato"
ADD CONSTRAINT situacaoCandidaturaId_constraint FOREIGN KEY (situacaoCandidaturaId) REFERENCES situacaocandidatura(id);

ALTER TABLE "candidato"
ADD CONSTRAINT situacaoUrnaId_constraint FOREIGN KEY (situacaoUrnaId) REFERENCES situacaocandidatourna(id);

ALTER TABLE "candidato"
ADD CONSTRAINT situacaoCandidatoTurnoId_constraint FOREIGN KEY (situacaoCandidatoTurnoId) REFERENCES situacaocandidatoturno(id);

ALTER TABLE "candidato"
ADD CONSTRAINT detalhaSituacaoCandidatoId_constraint FOREIGN KEY (detalhaSituacaoCandidatoId) REFERENCES detalhasituacaocandidato(id);

ALTER TABLE "candidato"
ADD CONSTRAINT partidoId_constraint FOREIGN KEY (partidoId) REFERENCES partido(id);

ALTER TABLE "candidato"
ADD CONSTRAINT coligacaoId_constraint FOREIGN KEY (coligacaoId) REFERENCES coligacao(id);

ALTER TABLE "candidato"
ADD CONSTRAINT nacionalidadeId_constraint FOREIGN KEY (nacionalidadeId) REFERENCES nacionalidade(id);

create table candidatura(
	id integer,
	numeroProtocolo bigint,
	inseridoUrna varchar (255)
	)

ALTER TABLE "candidatura" ADD PRIMARY KEY (id)




create table cargo(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "cargo" ADD PRIMARY KEY (id)

create table cassacao(
	id integer,
	motivo integer,
	candidatoId bigint,
	estadoId integer,
	municipioId integer
)

ALTER TABLE "cassacao" ADD PRIMARY KEY (id)

ALTER TABLE "cassacao"
ADD CONSTRAINT candidatoId_constraint FOREIGN KEY (candidatoId) REFERENCES candidato(id);

ALTER TABLE "cassacao"
ADD CONSTRAINT estado_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);

ALTER TABLE "cassacao"
ADD CONSTRAINT municipioId_constraint FOREIGN KEY (municipioId) REFERENCES municipios(id);


create table coligacao(
	id integer,
	nome varchar (255),
	composicao varchar (255),
	situacaoLegenda varchar (255),
	descricaoLegenda integer,
	agremiacao varchar (255),
	cargoId integer,
	partidoId integer,
	estadoId integer,
	municipioId integer
)

ALTER TABLE "coligacao" ADD PRIMARY KEY (id)

ALTER TABLE "coligacao" 
ADD CONSTRAINT cargoId_constraint FOREIGN KEY (cargoId) REFERENCES cargo(id);

ALTER TABLE "coligacao" 
ADD CONSTRAINT partidoId_constraint FOREIGN KEY (partidoId) REFERENCES partido(id);

ALTER TABLE "coligacao" 
ADD CONSTRAINT estado_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);

ALTER TABLE "coligacao" 
ADD CONSTRAINT municipioId_constraint FOREIGN KEY (municipioId) REFERENCES municipios(id);

create table corRaca(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "corraca" ADD PRIMARY KEY (id)

create table detalhaSituacaoCandidato(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "detalhasituacaocandidato" ADD PRIMARY KEY (id)

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

create table nacionalidade(
    id integer,
	descricao varchar (255)
	
)

ALTER TABLE "nacionalidade" ADD PRIMARY KEY (id)

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

create table situacaoCandidatoTurno(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "situacaocandidatoturno" ADD PRIMARY KEY (id)

create table situacaoCandidatoUrna(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "situacaocandidatourna" ADD PRIMARY KEY (id)

create table situacaoCandidatura(
	id integer,
	descricao varchar (255)
)

ALTER TABLE "situacaocandidatura" ADD PRIMARY KEY (id)

create table bemCandidato
    (		 
         id  bigint,
		numOrdemCandidato integer,
		descricao varchar (255),
		valorBem decimal,
		codigoTipoBemId integer,
		sqCandidatoId bigint,
		estadoId integer,
		municipioId integer
	)
	
	ALTER TABLE "bemcandidato" ADD PRIMARY KEY (id)  
	
	ALTER TABLE "bemcandidato"
	ADD CONSTRAINT sqCandidatoId_constraint FOREIGN KEY (sqCandidatoId) REFERENCES candidato(id);
	
	ALTER TABLE "bemcandidato"
	ADD CONSTRAINT codigoTipoBemId_constraint FOREIGN KEY (codigoTipoBemId) REFERENCES tipoBem(id);
	
	ALTER TABLE "bemcandidato"
	ADD CONSTRAINT municipioId_constraint FOREIGN KEY (municipioId) REFERENCES municipios(id);
	
	ALTER TABLE "bemcandidato"
	ADD CONSTRAINT estadoId_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);
        
    create table tipoBem(
	id integer,
	descricao varchar (255)
	)

	ALTER TABLE "tipobem" ADD PRIMARY KEY (id) 
	
	create table vagasCandidato(
	id integer,
		dataPosse varchar (255),
		dataEleicao varchar (255),
		qtdeVagas integer,
		estadoId integer,
		municipioId integer,
		cargoId integer
	)
	ALTER TABLE "vagascandidato" ADD PRIMARY KEY (id) 
	
	
ALTER TABLE "vagascandidato"
ADD CONSTRAINT cargoId_constraint FOREIGN KEY (cargoId) REFERENCES cargo(id);


ALTER TABLE "vagascandidato"
ADD CONSTRAINT estado_constraint FOREIGN KEY (estadoId) REFERENCES estado(id);

ALTER TABLE "vagascandidato"
ADD CONSTRAINT municipioId_constraint FOREIGN KEY (municipioId) REFERENCES municipios(id);


