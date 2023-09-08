CREATE TABLE [dbo].[Usersdb]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userId] INT NOT NULL, 
    [firstName] NVARCHAR(50) NOT NULL, 
    [lastName] NVARCHAR(50) NOT NULL, 
    [emailAddress] NVARCHAR(50) NOT NULL, 
    [phoneNumber] NVARCHAR(50) NOT NULL
)
