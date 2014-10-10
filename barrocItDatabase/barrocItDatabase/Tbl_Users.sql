CREATE TABLE [dbo].[Tbl_Users]
(
	[User_Id] INT NOT NULL PRIMARY KEY, 
    [username] NCHAR(12) NOT NULL, 
    [password] NCHAR(12) NOT NULL, 
    [department] NCHAR(15) NOT NULL, 
    [department_id] INT NOT NULL
)
