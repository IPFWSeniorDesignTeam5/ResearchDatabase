CREATE TABLE [dbo].[ApplicationMechanic] (
    [ApplicationId] INT NOT NULL,
    [MechanicId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC, [MechanicId] ASC),
    CONSTRAINT [FK_ApplicationMechanic_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ApplicationMechanic_ToMechanic] FOREIGN KEY ([MechanicId]) REFERENCES [dbo].[Mechanic] ([Id]) ON DELETE CASCADE
);

