CREATE TABLE [db_owner].[OperationData] (
    [CPR]            NCHAR (10)      NOT NULL,
	[OperationsID]	 INT			NOT NUll,
    PRIMARY KEY CLUSTERED ([OperationsID] ASC),
    FOREIGN KEY ([CPR]) REFERENCES [db_owner].[Patient] ([CPR])
	);