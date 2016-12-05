CREATE VIEW [dbo].[VW_GenreReview]
	AS SELECT        Genre.Description, SUM(Review.TimeSpent) AS ReviewTime, AVG(Review.Rating) AS AverageRating
		FROM            Application INNER JOIN
								 ApplicationReview ON Application.Id = ApplicationReview.ApplicationId INNER JOIN
								 Review ON ApplicationReview.ReviewId = Review.Id INNER JOIN
								 ApplicationGenre ON Application.Id = ApplicationGenre.ApplicationId INNER JOIN
								 Genre ON ApplicationGenre.GenreId = Genre.Id
		GROUP BY Genre.Description
