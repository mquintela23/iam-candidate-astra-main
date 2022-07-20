CREATE TABLE [dbo].[Vegetable]
(
	[ID] [uniqueidentifier] NOT NULL,

	[Name] [nvarchar] (50) NOT NULL,

	[EdiblePart] [nvarchar] (30) NOT NULL,

	[IsBotanicalFruit] [bit] NOT NULL,

	CONSTRAINT [PK_Vegetable] PRIMARY KEY NONCLUSTERED ([ID] ASC)
);
GO

CREATE UNIQUE CLUSTERED INDEX [AK_Vegetable] ON [dbo].[Vegetable] ([Name] ASC);
GO
