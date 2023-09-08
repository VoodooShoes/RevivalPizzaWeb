CREATE TABLE [dbo].[MenuProductsdb]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [productId] INT NOT NULL, 
    [productName] NVARCHAR(50) NOT NULL, 
    [description] NVARCHAR(MAX) NOT NULL, 
    [price] MONEY NOT NULL
)
