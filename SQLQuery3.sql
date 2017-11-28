CREATE TABLE [db_owner].[Maaling] (
    [MaaleID]        INT             IDENTITY (1, 1) NOT NULL,
    [Måledata]       VARBINARY (MAX) NOT NULL,
	[Sekvensnr]		 INT			NOT NULL,
	[OperationsID]	 INT			NOT NUll,
    PRIMARY KEY CLUSTERED ([MaaleID] ASC),
    FOREIGN KEY ([OperationsID]) REFERENCES [db_owner].[OperationsData] ([OperationsID])
);