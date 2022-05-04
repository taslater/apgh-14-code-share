# No More iTunes #

Instructions:

* Write a program that lets you have a list of albums/songs
* You should be able to a) View library (show all albums and songs)
* You should be able to b) Add Albums
* You should be able to c) Add Songs to Albums

## Groups/Teams ##

Team 1: On the run - Kelvin

* Rich
* Tobias
* Jeremy
* Harrison

Team 2: Paddling a canoe - Scott

* David
* Joe
* Yemi
* Tom

Team 3: Running free - Joyce

* Renat
* Jessica
* Donna
* James

Team 4: Shut the front door - Sam

* Spenser
* Andrew
* Shauna
* Imani

## Creating SQL Tables ##

Create SQLite Tables:

```sql
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

```

Create MSSQL Tables:

```sql
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
```
