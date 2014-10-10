CREATE TABLE [dbo].[tbl_appointments]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Customer_Id] int FOREIGN KEY REFERENCES tbl_Customers(Customer_Id) NOT NULL, 
    [date] DATE NULL, 
    [location] NCHAR(30) NULL, 
    [participants] NCHAR(30) NULL,
)
