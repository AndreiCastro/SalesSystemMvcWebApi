USE SalesSystem;

IF NOT EXISTS(SELECT * FROM sys.tables WHERE NAME = 'Clientes')
BEGIN
	CREATE TABLE Clientes
	(
		Id INT PRIMARY KEY IDENTITY(1,1)
		, Nome NVARCHAR(40) NOT NULL
		, Email NVARCHAR(30) NOT NULL
		, CpfCnpj NVARCHAR(14) NOT NULL
		, Logradouro NVARCHAR(30) NOT NULL
		, Bairro NVARCHAR(20) NOT NULL
		, UF NVARCHAR(2) NOT NULL
		, Cep NVARCHAR(10) NOT NULL
		, Cidade NVARCHAR(20) NOT NULL
		, Telefone NVARCHAR(14) NOT NULL			
	);

	CREATE TABLE Produtos
	(
		Id INT PRIMARY KEY IDENTITY(1,1)
		, Nome NVARCHAR(40) NOT NULL
		, Descricao NVARCHAR(MAX) NOT NULL
		, Preco DECIMAL(18,2) NOT NULL
		, UnidadeMedida NVARCHAR(3) NOT NULL
		, Quantidade INT NOT NULL			
		, Peso INT NOT NULL
		, DataValidade DATETIME NOT NULL
	);

	CREATE TABLE Vendas
	(
		Id INT PRIMARY KEY IDENTITY(1,1)			
		, DataVenda DATETIME NOT NULL
		, QuantidadeProduto INT NOT NULL
		, ValorTotal DECIMAL(18,2) NOT NULL
		, Descricao NVARCHAR(MAX)
		, Desconto DECIMAL(18,2)
		, IdCliente INT NOT NULL
		, IdProduto INT NOT NULL
		
		CONSTRAINT FK_ClienteVenda FOREIGN KEY (IdCliente) REFERENCES Clientes (Id)
		, CONSTRAINT FK_ProdutoVenda FOREIGN KEY (IdProduto) REFERENCES Produtos (Id)
	);
END