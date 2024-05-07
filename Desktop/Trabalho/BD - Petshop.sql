create database Petshop;
use Petshop;

create table Funcionario (
	idFuncionario int auto_increment primary key,
    nome varchar(60) not null,
    cargo varchar(60),
    salario decimal(10,2) not null,
    data_contratacao date not null,
    email varchar(70),
    telefone int not null
);

create table Produto (
	idProduto int auto_increment primary key,
    nome varchar(60),
    preco decimal(10,2),
    estoque int
);

create table Clientes (
	idClientes int auto_increment primary key,
    nome varchar(50),
    endereco varchar(50),
    email varchar(100),
    telefone varchar(20)
);

create table Vendas (
	idVendas int auto_increment primary key,
    data_hora datetime,
    valor_venda decimal(10,2),
    idCliente int,
    idFuncionario int,
    foreign key (idCliente) references Clientes(idClientes),
    foreign key (idFuncionario) references Funcionario(idFuncionario)
);

create table Itens_Venda (
	idItens int auto_increment primary key,
    idVendas int,
    idProduto int,
    quantidade decimal(10,2),
    preco_unitario decimal(10,2),
    foreign key (idVendas) references Vendas(idVendas),
    foreign key (idProduto) references Produto(idProduto)
);

create table Servicos (
	idServicos int auto_increment primary key,
    nome_servico varchar(100),
    descricao text,
    preco decimal(10,2)
);

create table Agendamento_servicos (
	idAgendamento int auto_increment primary key,
    data_hora datetime,
    idCliente int,
    idServico int,
    observacoes text,
    foreign key (idCliente) references Clientes(idClientes),
    foreign key (idServico) references Servicos(idServicos)
);




