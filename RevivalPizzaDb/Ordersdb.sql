CREATE TABLE [dbo].[Ordersdb]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [orderId] INT NOT NULL, 
    [user] NVARCHAR(50) NOT NULL, 
    [productOrdered] NVARCHAR(MAX) NOT NULL, 
    [totalPrice] MONEY NOT NULL
)
