CREATE VIEW [dbo].[VW_Mechanics]
	AS SELECT Mechanic.Description,
			  COUNT(am.MechanicId) AS Relations
			  FROM
			  dbo.ApplicationMechanic am JOIN Mechanic ON am.MechanicId = Mechanic.Id
			  GROUP BY Mechanic.Description;