CREATE DATABASE IF NOT EXISTS GerenciadorQKZ;
USE GerenciadorQKZ;

 
CREATE TABLE IF NOT EXISTS Fornecedores (
    IdFornecedor INT AUTO_INCREMENT PRIMARY KEY, 
    Nome VARCHAR(100) NOT NULL,                  
    CNPJ VARCHAR(20) NOT NULL UNIQUE,            
    Telefone VARCHAR(20),                        
    Email VARCHAR(100),                          
    Endereco VARCHAR(255)                        
);


CREATE TABLE IF NOT EXISTS Produtos (
    IdProduto INT AUTO_INCREMENT PRIMARY KEY,    
    Nome VARCHAR(100) NOT NULL,                  
    Descricao TEXT,                              
    Preco DECIMAL(10, 2) NOT NULL,               
    QuantidadeEstoque INT NOT NULL               
);

 
CREATE TABLE IF NOT EXISTS FornecedorProduto (
    IdFornecedor INT NOT NULL,                     
    IdProduto INT NOT NULL,                      
    

    PRIMARY KEY (IdFornecedor, IdProduto),
    
  
    CONSTRAINT fk_forn_rel FOREIGN KEY (IdFornecedor) REFERENCES Fornecedores(IdFornecedor) ON DELETE RESTRICT,
    CONSTRAINT fk_prod_rel FOREIGN KEY (IdProduto) REFERENCES Produtos(IdProduto) ON DELETE RESTRICT
);