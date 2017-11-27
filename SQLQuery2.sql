CREATE TABLE [db_owner].[OperationsData] (
    [OperationsID]   INT             NOT NULL,
    [Måledata]       VARBINARY (MAX) NOT NULL,
	[Maaletidspunkt] Datetime		 NOT NULL,
	[Kommentar]		NvarChar(500)	 Null,
	[Kalibrering]	 INT			 NOT NULL, 
	[Nulpunktsjustering] INT		 NOT NULL,
	[CPR]			NChar(10)		 NOT NULL,
    PRIMARY KEY CLUSTERED ([OperationsID] ASC),
    FOREIGN KEY ([CPR]) REFERENCES [db_owner].[Patient] ([CPR])
);