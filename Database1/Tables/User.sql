CREATE TABLE [dbo].[User]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [LastName] NCHAR(50) NOT NULL, 
    [FirstName] NCHAR(50) NOT NULL, 
    [Position] TINYINT NOT NULL
)
