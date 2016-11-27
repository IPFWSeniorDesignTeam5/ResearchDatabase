﻿CREATE TABLE [dbo].[ReviewPro]
(
	[ReviewId] INT NOT NULL,
	[AppProId] INT NOT NULL, 
	CONSTRAINT [FK_ReviewPro_ToReview] FOREIGN KEY ([ReviewId]) REFERENCES [Review]([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ReviewPro_ToPro] FOREIGN KEY ([AppProId]) REFERENCES [AppPro]([Id]) ON DELETE CASCADE
)
