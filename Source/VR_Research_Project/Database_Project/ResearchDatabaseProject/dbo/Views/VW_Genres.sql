CREATE VIEW [dbo].[VW_Genres]
	AS SELECT Genre.Description,
			  COUNT(agr.GenreId) AS Relations
			  FROM
			  dbo.ApplicationGenre agr JOIN Genre ON agr.GenreId = Genre.Id
			  GROUP BY Genre.Description;
