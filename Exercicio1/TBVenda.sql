CREATE TABLE [dbo].[TBVenda]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [Nome] VARBINARY(MAX) NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [Lucro] DECIMAL NOT NULL
)
