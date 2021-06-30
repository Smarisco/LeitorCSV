--Monte consultas (SELECT) para executar em seu banco de dados
--respondendo:
--○ Quais os 5 partidos que mais tiveram candidatos cassados? Liste nome e
--CPF destes candidatos.

select nomecoligacao, count(*)
	from politica.candidato
	group by  nomecoligacao
	order by count(*) desc

-- Quantos homens e quantas mulheres são candidatos?

select descricao, count(*) 
	from genero
	group by descricao
	order by count(*) desc
	
--Faça uma ordenação decrescente da quantidade de candidatos por cor/raça
--declaradas.

select descricaocorraca , count (*) 
	from politica.candidato
	WHERE descricaocorraca != 'SEM INFORMAÇÃO'
	group by descricaocorraca
	order by count(*) desc

--Quais os 5 candidatos que possuem a maior quantidade de Bens declarados
--em valores financeiros? Liste nome completo, CPF e valor total em bens.

select totaldebens, nomecompleto
	from politica.candidato 
	order by totaldebens desc
	limit 1

--Liste os 10 candidatos mais idosos (nome, CPF e idade). Em caso de
--empate, lista os ordenados pelo nome do candidato.

select datadenascimento, nomecompleto
	from politica.candidato
	order by datadenascimento, nomecompleto asc
	limit 10


--Quais os bens mais valiosos declarados (Ordenar decrescentemente os 10
--maiores)