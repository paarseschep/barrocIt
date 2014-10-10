CREATE TABLE [dbo].[tbl_invoices]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Project_id] int FOREIGN KEY REFERENCES tbl_Projects(Project_id) NOT NULL,
	[factuurBedrag] int not null,
	[invoiceDate] date not null,
	[grootboekrekeningnummer] int not null,
	[BTWCode] smallint null,
	[paid] bit null DEFAULT 0,
)
