﻿CREATE VIEW [dbo].[VW_MechanicReview]
	AS SELECT        Mechanic.Description, SUM(Review.TimeSpent) AS ReviewTime, ROUND(AVG(CAST(Review.Rating AS FLOAT)),2) AS AverageRating
FROM            Application INNER JOIN
                         ApplicationReview ON Application.Id = ApplicationReview.ApplicationId INNER JOIN
                         Review ON ApplicationReview.ReviewId = Review.Id INNER JOIN
                         ApplicationMechanic ON Application.Id = ApplicationMechanic.ApplicationId INNER JOIN
                         Mechanic ON ApplicationMechanic.MechanicId = Mechanic.Id
GROUP BY Mechanic.Description;
