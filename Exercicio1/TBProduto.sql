CREATE TABLE [dbo].[TBProduto]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Nome] VARCHAR(50) NOT NULL, 
    [PrecoVenda] DECIMAL NOT NULL, 
    [PrecoCusto] DECIMAL NOT NULL, 
    [DataFabricacao] DATETIME NOT NULL, 
    [DataValidade] DATETIME NOT NULL, 
    [Disponivel] BIT NOT NULL
)
