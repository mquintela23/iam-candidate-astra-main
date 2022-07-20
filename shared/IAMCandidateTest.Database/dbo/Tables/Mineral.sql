CREATE TABLE [dbo].[Mineral]
(
	[ID] [uniqueidentifier] NOT NULL,

	[Name] [nvarchar] (50) NOT NULL,

	-- Data from https://geology.com/minerals/
	[Hardness] [decimal] (3, 1) NOT NULL,
	[Luster] [nvarchar] (20) NOT NULL,
	[Color] [nvarchar] (20) NOT NULL,
	[Streak] [nvarchar] (20) NOT NULL,
	[SpecificGravity] [decimal] (4, 2) NOT NULL,
	[Diaphaneity] [nvarchar] (40) NOT NULL,

	CONSTRAINT [PK_Mineral] PRIMARY KEY NONCLUSTERED ([ID] ASC)
);
GO

CREATE UNIQUE CLUSTERED INDEX [AK_Mineral] ON [dbo].[Mineral] ([Name] ASC);
GO
