CREATE VIEW [dbo].[VW_GenrePairs]
	AS SELECT DISTINCT G1Description + '/' + G2Description AS Pair, COUNT(*) / 2 AS Relations
		FROM
		(	SELECT 
			(SELECT Genre.Description FROM Genre WHERE Genre.Id = CASE WHEN ag1.GenreId > ag2.GenreId THEN ag1.GenreId ELSE ag2.GenreId END) AS G1Description,
			(SELECT Genre.Description FROM Genre WHERE Genre.Id = CASE WHEN ag1.GenreId > ag2.GenreId THEN ag2.GenreId ELSE ag1.GenreId END) AS G2Description
			FROM ApplicationGenre ag1 JOIN ApplicationGenre ag2 ON ag1.ApplicationId = Ag2.ApplicationId AND ag1.GenreId <> ag2.GenreId
		) qry_1
		GROUP BY G1Description + '/' + G2Description;
