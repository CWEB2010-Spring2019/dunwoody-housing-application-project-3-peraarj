CREATE TABLE [dbo].[Table]
(
	[Res_ID] NCHAR(5) NOT NULL PRIMARY KEY IDENTITY, 
    [Res_FName] NCHAR(15) NOT NULL, 
    [Res_LName] NCHAR(15) NOT NULL, 
    [Res_Cat] NCHAR(10) NOT NULL, 
    [Room_Num] INT NOT NULL, 
    [Floor_Num] INT NOT NULL
)

GO
