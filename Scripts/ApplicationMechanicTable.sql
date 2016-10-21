CREATE TABLE [dbo].[ApplicationMechanic]
(
    [ApplicationId] INT NOT NULL , 
    [MechanicId] INT NOT NULL, 
    PRIMARY KEY ([ApplicationId], [MechanicId]), 
    CONSTRAINT [FK_ApplicationMechanic_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [Application]([Id]), 
    CONSTRAINT [FK_ApplicationMechanic_ToMechanic] FOREIGN KEY ([MechanicId]) REFERENCES [Mechanic]([Id])
)
