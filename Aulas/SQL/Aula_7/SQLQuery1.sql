/*
create table cliente(
rg integer primary key not null, 
e_mail varchar(50),
nome varchar(50),
telefone numeric(20),
);

create table imovel(
id_imovel integer primary key not null, 
area varchar(50),
forma_pagamento varchar(50),
tipo_operacao varchar(20),
);

create table atendimento(
id_atendimento integer primary key not null, 
horario time,
data_atendimento datetime,
);

create table visita(
codigo_visita integer primary key not null, 
horario time,
data_atendimento datetime,
);

create table proposta(
codigo_proposta integer primary key not null, 
valor numeric(20),
forma_pagamento varchar(50),
);

create table funcionarios(
codigo_func integer primary key not null, 
nome varchar(50),
cargo varchar(50),
telefone numeric(20),
);

create table teto_seg(
codigo_teto integer primary key not null, 
telefone numeric(20),
);

create table proprietario(
codigo_prop integer primary key not null, 
nome varchar(50),
);
*/
