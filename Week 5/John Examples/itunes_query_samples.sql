-- SELECT * FROM Albums -- All albums
-- SELECT * FROM Songs -- All songs

-- SELECT * FROM Songs WHERE AlbumId = 3 -- All songs from a specific album

SELECT * FROM Albums
JOIN Songs ON Albums.Id = Songs.AlbumId
