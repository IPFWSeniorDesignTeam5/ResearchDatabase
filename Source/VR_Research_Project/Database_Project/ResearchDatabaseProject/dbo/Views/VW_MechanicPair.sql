CREATE VIEW [dbo].[VW_MechanicPair]
	AS SELECT DISTINCT G1Description + '/' + G2Description AS Pair, COUNT(*) / 2 AS Relations
	FROM
	(	SELECT 
		(SELECT Mechanic.Description FROM Mechanic WHERE Mechanic.Id = CASE WHEN ag1.MechanicId > ag2.MechanicId THEN ag1.MechanicId ELSE ag2.MechanicId END) AS G1Description,
		(SELECT Mechanic.Description FROM Mechanic WHERE Mechanic.Id = CASE WHEN ag1.MechanicId > ag2.MechanicId THEN ag2.MechanicId ELSE ag1.MechanicId END) AS G2Description
		FROM ApplicationMechanic ag1 JOIN ApplicationMechanic ag2 ON ag1.ApplicationId = Ag2.ApplicationId AND ag1.MechanicId <> ag2.MechanicId
	) qry_1
	GROUP BY G1Description + '/' + G2Description;
