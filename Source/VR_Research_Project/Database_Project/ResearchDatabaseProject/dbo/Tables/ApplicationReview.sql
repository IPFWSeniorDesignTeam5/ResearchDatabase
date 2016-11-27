CREATE TABLE [dbo].[ApplicationReview] (
    [ApplicationId] INT NOT NULL,
    [ReviewId]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ReviewId] ASC, [ApplicationId] ASC),
    CONSTRAINT [FK_ApplicationReview_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ApplicationReview_ToReview] FOREIGN KEY ([ReviewId]) REFERENCES [dbo].[Review] ([Id]) ON DELETE CASCADE
);

