create database myfinanceweb;

use myfinanceweb;

create table planocontas(
	id int not null identity(1,1), --identity usado para ser auto increment
	descricao varchar(100) not null,
	tipo char(1) not null,
	primary key (id)
);

create table transacoesFinanceiras(
	id int not null identity(1,1),
	data datetime not null,
	valor decimal(10,2) not null,
	historico varchar(255),
	tipo char(1) not null,
	planocontasid int not null,
	primary key (id),
	foreign key (planocontasid) references planocontas (id)
);