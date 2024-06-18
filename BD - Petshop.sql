CREATE DATABASE Petshop;
USE Petshop;
/*DROP DATABASE Petshop;*/

CREATE TABLE cargo (
    cod_cargo INT AUTO_INCREMENT PRIMARY KEY,
    nome_cargo VARCHAR(25) NOT NULL
);

CREATE TABLE funcionario (
    cod_func INT AUTO_INCREMENT PRIMARY KEY,
    nome_func VARCHAR(120) NOT NULL,
    email_func VARCHAR(120) UNIQUE NOT NULL,
    telefone_func VARCHAR(15),
    senha_func VARCHAR(255) NOT NULL,
    cod_cargo INT NOT NULL,
    FOREIGN KEY (cod_cargo) REFERENCES cargo (cod_cargo) ON DELETE CASCADE
);

CREATE TABLE cliente (
    cod_cliente INT AUTO_INCREMENT PRIMARY KEY,
    nome_cli VARCHAR(120) NOT NULL,
    telefone_cli VARCHAR(15),
    email VARCHAR(120) UNIQUE,
    endereco VARCHAR(255)
);

CREATE TABLE animal (
    cod_animal INT AUTO_INCREMENT PRIMARY KEY,
    nome_animal VARCHAR(120) NOT NULL,
    tipo VARCHAR(50),
    cod_cliente INT NOT NULL,
    FOREIGN KEY (cod_cliente) REFERENCES cliente(cod_cliente) ON DELETE CASCADE
);

CREATE TABLE produto (
    cod_produto INT AUTO_INCREMENT PRIMARY KEY,
    nome_produto VARCHAR(120) NOT NULL,
    descricao TEXT,
    preco_produto DECIMAL (10,2) NOT NULL,
    quantidade INT NOT NULL,
    CHECK (preco_produto > 0),
    CHECK (quantidade > 0)
);

CREATE TABLE vendas (
    cod_vendas INT AUTO_INCREMENT PRIMARY KEY,
    data_venda DATE NOT NULL,
    cod_cliente INT,
    total DECIMAL(10,2) NOT NULL,
    cod_func INT,
    FOREIGN KEY (cod_cliente) REFERENCES cliente(cod_cliente) ON DELETE SET NULL,
    FOREIGN KEY (cod_func) REFERENCES funcionario(cod_func) ON DELETE SET NULL
);

CREATE TABLE itens_vendas (
    cod_itens_vendas INT AUTO_INCREMENT PRIMARY KEY,
    cod_vendas INT NOT NULL,
    cod_produto INT NOT NULL,
    preco DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (cod_vendas) REFERENCES vendas(cod_vendas) ON DELETE CASCADE,
    FOREIGN KEY (cod_produto) REFERENCES produto(cod_produto) ON DELETE CASCADE
);

CREATE TABLE servico (
    cod_servico INT AUTO_INCREMENT PRIMARY KEY,
    nome_servico VARCHAR(100) NOT NULL,
    descricao TEXT,
    preco_servico DECIMAL(10, 2) NOT NULL
);

CREATE TABLE agendamento (
    cod_agendamento INT AUTO_INCREMENT PRIMARY KEY,
    data_agendamento DATE NOT NULL,
    hora_agendamento TIME NOT NULL,
    cod_cliente INT,
    cod_animal INT,
    cod_servico INT,
    cod_func INT,
    status VARCHAR(9),
    FOREIGN KEY (cod_cliente) REFERENCES cliente(cod_cliente) ON DELETE SET NULL,
    FOREIGN KEY (cod_animal) REFERENCES animal(cod_animal) ON DELETE SET NULL,
    FOREIGN KEY (cod_servico) REFERENCES servico(cod_servico) ON DELETE SET NULL,
    FOREIGN KEY (cod_func) REFERENCES funcionario(cod_func) ON DELETE SET NULL
);