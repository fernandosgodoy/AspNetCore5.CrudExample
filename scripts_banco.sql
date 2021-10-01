create table Alunos (
	Id		int		identity(1,1)		not null,
	Nome	varchar(50)					not null,
	Email	varchar(50)					not null,
)

alter table Alunos
	add constraint pk_alunos	primary key(Id)

insert into Alunos values ('Aluno 1', 'aluno1@gmail.com')
insert into Alunos values ('Aluno 2', 'aluno2@gmail.com')

/*
Professores
Id
Nome
Email
Disciplina
*/