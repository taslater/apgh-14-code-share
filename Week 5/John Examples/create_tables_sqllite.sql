CREATE TABLE [Albums]
(
	[Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
    [Artist] TEXT NULL, 
    [Title] TEXT NULL, 
    [Genre] TEXT NULL, 
    [isNeilC] INTEGER NULL, 
    [Year] INTEGER NULL
);
go;
CREATE TABLE [Songs]
(
	[Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
    [Length] INTEGER NULL, 
    [Rating] INTEGER NULL, 
    [Title] TEXT NULL, 
    [GuestArtist] TEXT NULL, 
    [AlbumId] INTEGER NULL
);
go;
