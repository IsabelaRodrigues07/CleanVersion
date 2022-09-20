CREATE TABLE [dbo].[Produto] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Nome] NVARCHAR (MAX) NOT NULL,
	[Quantidade] INT  NOT NULL,
	[Categoria] NVARCHAR (MAX) NOT NULL,
    [Preco] INT NOT NULL, 
    CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED ([Id] ASC)
);

