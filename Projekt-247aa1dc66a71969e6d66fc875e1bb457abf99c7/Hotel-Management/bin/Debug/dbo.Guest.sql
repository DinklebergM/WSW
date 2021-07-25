CREATE TABLE [dbo].[Guest]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Lastname] NCHAR(30) NOT NULL, 
    [Firstname] NCHAR(30) NOT NULL, 
    [Date(arrival)] DATE NOT NULL, 
    [Date(depature)] NCHAR(10) NOT NULL
)
