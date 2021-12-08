/*
create table cliente(
cod_cliente integer primary key not null, 
nome_cliente varchar(50),
endereco varchar(50),
cidade varchar(50),
cep char(8),
uf char(2),
cnpj numeric(20),
ie numeric(20)
);

create table vendedor(
cod_vendedor integer primary key not null,
nome_vendedor varchar(50),
salario_fixo numeric(10,2),
faixa_comissao char(1)
);

create table produto(
cod_produto integer primary key not null,
unidade_produto varchar(10),
descricao_produto varchar (50),
valor_unitario numeric(10,2)
);

*/

/*
create table pedido(
num_pedido integer primary key not null,
prazo_entrega numeric(5),
cod_cliente integer,
cod_vendedor integer,
foreign key (cod_cliente) references cliente,
foreign key (cod_vendedor) references vendedor
);
*/

/*
create table item_do_pedido(
num_pedido integer,
cod_produto integer,
quantidade numeric(5),
foreign key (num_pedido) references pedido,
foreign key (cod_produto) references produto
);
*/

/*
insert into cliente(cod_cliente,nome_cliente, endereco, cidade, cep, uf,cnpj, ie)
values
(720, 'ana','rua 17 a. 19', 'niteroi', '24358310', 'rj', 12113231000134, 2134);
(870, 'Flávio', 'AV. Pres. Vargas 10', 'São Paulo', '22763931', 'SP', 2253412693879, 4631),
(110, 'Jorge', 'Rua Caiapo 13', 'Curitiba', '30078500', 'PR', 1451276498349, null),
(222, 'Lúcia', 'Rua Itabira 123 Loja 9', 'Belo Horizonte', '22124391', 'MG', 2831521393488, 2985),
(830, 'Mauricio', 'Av. Paulista 1236 s1/2345', 'São Paulo', '3012683', 'SP', 3281698574656, 9343),
(130, 'Edmar', 'Rua da Praia sn/', 'Salvador', '30079300', 'BA', 234632842349, 7121),
(410, 'Rodolfo','Largo da Lapa 27 sobrado','Rio de Janeiro','30078900','RJ',1283512823469,7431),
(20, 'Beth','Av. Climério n. 45','São Paulo','25679300','SP',3248512673268,9280),
(157,'Paulo','Tv. Moraes c/3','Londrina',null,'PR',328482233242,1923),
(180,'Lívia','Av. Beira Mar n. 1256','Florianópolis','30077500','SC',1273657123474, null),
(260,'Susana','Rua Lopes Mendes 12','Niterói','30046500','RJ',217635712329,2530),
(290,'Renato','Rua Meireles n. 123 b1.2 s1.345','São Paulo','30225900','SP',1327657112314,1820),
(390,'Sebastião','Rua da Igreja n. 10','Uberaba','30438700','MG',321765472133,9071),
(234,'José','Quadra 3 bl. 3 sl. 1003','Brasília','22841650','DF',2176357612323,2931);
*/

/*
insert into pedido(num_pedido,prazo_entrega,cod_cliente,cod_vendedor)
values
(121,20,410,209),
(97,20,720,101),
(101,15,720,101),
(137,20,720,720),
(148,20,720,101),
(189,15,870,213),
(104,30,110,101),
(203,30,830,250),
(98,20,410,209),
(143,30,20,111),
(105,15,180,240),
(111,20,260,240),
(103,20,260,11),
(91,20,260,11),
(138,20,260,11),
(108,15,290,310),
(119,30,390,250),
(127,10,410,11);
*/

/*
INSERT INTO vendedor(cod_vendedor,nome_vendedor,salario_fixo,faixa_comissao)
VALUES
(209, 'José',1800,'C'),
(111,'Carlos', 2490, 'A'),
(11,'Joao', 2780, 'C'),
(240,'Antônio', 9500, 'C'),
(720,'Felipe', 4600, 'A'),
(213,'Jonas', 2300, 'A'),
(101,'João', 2650, 'C'),
(310,'Josias', 870, 'B'),
(250,'Mauricio', 2930, 'B');
*/

/*
insert into produto(cod_produto,unidade_produto,descricao_produto,valor_unitario)
values
(25,'kg','queijo',0.97),
(31,'bar','chocolate',0.87),
(78,'l','vinho',2),
(22,'m','linho',0.11),
(30,'sac','açucar',0.3),
(53,'m','linha',1.8),
(13,'g','ouro',6.18),
(45,'m','madeira',0.25),
(87,'m','cano',1.97),
(77,'m','papel',1.05);
*/

/*
insert into item_do_pedido(num_pedido,cod_produto,quantidade)
values
(101,78,18),
(101,13,5),
(98,77,5),
(148,45,8),
(148,31,7),
(148,77,3),
(148,25,10),
(148,78,30),
(104,53,32),
(203,31,6),
(189,78,45),
(143,31,20),
(143,78,10),
(105,78,10),
(111,25,10),
(111,78,70),
(103,53,57),
(91,77,40),
(138,22,10),
(138,77,35),
(138,53,18),
(108,13,17),
(119,77,40),
(119,13,6),
(119,22,10),
(119,53,43),
(137,13,8);
*/

/*
select unidade_produto, descricao_produto, valor_unitario from produto;
*/

/*
select nome_cliente, endereco,cnpj from cliente;
*/

/*
select * from vendedor
*/

/*
select cod_vendedor as 'numero',nome_vendedor as 'Nome',salario_fixo as 'rendimento',faixa_comissao as 'comissão' from vendedor;
*/






