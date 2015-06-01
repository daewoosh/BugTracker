CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] NCHAR(10) NOT NULL, 
    [State] TINYINT NOT NULL, 
    [DateOfCreation] NCHAR(10) NOT NULL, 
    [User] NCHAR(10) NOT NULL
)


