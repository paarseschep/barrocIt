CREATE TABLE [dbo].[Tbl_Projects]
(
	[Project_id] INT NOT NULL PRIMARY KEY,
	[Customer_id] int FOREIGN KEY REFERENCES Tbl_Customers(customer_id) NOT NULL,
    [name] NCHAR(30) NOT NULL, 
    [description] NCHAR(100) NOT NULL,
	[active]bit not null DEFAULT 0, 
    [completed] BIT NOT NULL DEFAULT 0, 
    [deadline] DATE NULL, 
    [price] INT NOT NULL, 
    [numberofinvoices] INT NULL, 
    [contactdate] DATE NULL,

)
