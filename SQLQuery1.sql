create table paises(
	id int not null identity(10,1) primary key,
	pais varchar(55) not null,
	sigla varchar(3),
	ddi varchar(4) not null,
	moeda varchar(3)
	);
create table estados(
	id int not null identity(100,1)primary key,
	estado varchar(50) not null,
	uf varchar(2) not null,
	idpais int foreign key references paises(id)
);
create table cidades(
	id int not null identity(1000,1)primary key,
	cidade varchar(50) not null,
	ddd varchar(4),
	idestado int foreign key references estados(id)
);
create table fornecedor(
	id int not null identity(10000,1)primary key,
	cnpj varchar(18) not null,
	razaosocial varchar(100) not null,
	rua varchar(100) not null,
	bairro varchar (55),
	numero varchar(10),
	cep varchar(15),
	telefone varchar(20),
	email varchar(100),
	idcidade int foreign key references cidades(id)
);
	

create table produtos(
	id int not null identity(100000,1)primary key,
	produto varchar(55) not null,
	grupo varchar(55),
	codigobarra varchar(100),
	referencia varchar(55),
	preco decimal(10,2),
	und int,
	idfornecedor int foreign key references fornecedor(id)
);
create table prodForn(
	idforn int foreign key references fornecedor(id),
	idprod int foreign key references produtos(id)
	precoUltCompra decimal(10,2),
	dataUltCompra datetime
)