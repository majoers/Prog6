CREATE TABLE [dbo].[Hotelroom]
(
	[Roomnumber] INT NOT NULL PRIMARY KEY, 
    [Roomtype] VARCHAR(50) NOT NULL, 
    [Beds] INT NOT NULL, 
    CONSTRAINT [FK_Roomtype_Roomtype] FOREIGN KEY ([Roomtype]) REFERENCES dbo.Roomtype([Roomtype])
)
