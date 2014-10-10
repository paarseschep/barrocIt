CREATE TABLE [dbo].[Tbl_Customers]
(
	[Customer_Id] INT NOT NULL PRIMARY KEY, 
    [firstname] NCHAR(30) NOT NULL, 
    [lastname] NCHAR(30) NOT NULL, 
    [companyName] NCHAR(30) NOT NULL, 
    [email_company] NCHAR(100) NOT NULL, 
    [adress1] NCHAR(30) NOT NULL, 
    [postalCode1] NCHAR(30) NOT NULL,
	[city1] NCHAR(30) NOT NULL,
	[adress2] NCHAR(30) NULL,
	[postalcode2] NCHAR(30) NULL,
	[city2]NCHAR(30)NULL,
	[phonenumber]nchar(10)NOT NULL,
	[faxnumber]nchar(20)NOT NULL,
	[insurance_id]nchar(15)not null,
	[BKR_worthy]bit not null DEFAULT 0, 
    [limit] MONEY NOT NULL DEFAULT 0,

)
