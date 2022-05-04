CREATE TABLE [dbo].[Albums]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Artist] NVARCHAR(100) NULL, 
    [Title] NVARCHAR(100) NULL, 
    [Genre] NVARCHAR(100) NULL, 
    [isNeilC] BIT NULL, 
    [Year] INT NULL
)

CREATE TABLE [dbo].[Songs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Length] INT NULL, 
    [Rating] INT NULL, 
    [Title] NVARCHAR(50) NULL, 
    [GuestArtist] NVARCHAR(50) NULL, 
    [AlbumId] INT NULL
)
