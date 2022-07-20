CREATE TABLE [dbo].[Animal]
(
	[ID] [uniqueidentifier] NOT NULL,

	[CommonName] [nvarchar] (50) NOT NULL,

	[LegCount] [int] NOT NULL,
	[WingCount] [int] NOT NULL,
	[CanFly] [bit] NOT NULL,

	-- Animal is Domain 'Eukaryota', Kingdom 'Animalia', so start at Phylum.
	[TaxPhylum] [nvarchar] (50) NOT NULL,
	[TaxClass] [nvarchar] (50) NOT NULL,
	[TaxOrder] [nvarchar] (50) NOT NULL,
	[TaxFamily] [nvarchar] (50) NOT NULL,
	[TaxGenus] [nvarchar] (50) NOT NULL,
	[TaxSpecies] [nvarchar] (50) NOT NULL,

	CONSTRAINT [PK_Animal] PRIMARY KEY NONCLUSTERED ([ID] ASC)
);
GO

CREATE UNIQUE CLUSTERED INDEX [AK_Animal] ON [dbo].[Animal] ([CommonName] ASC);
GO
