CREATE TABLE [dbo].[Booking]
(
	[TamagotchiName] VARCHAR(50) NOT NULL, 
    [HotelroomNumber] INT NOT NULL, 
    CONSTRAINT [FK_Tamagotchi_Name] FOREIGN KEY ([TamagotchiName]) REFERENCES dbo.Tamagotchi([Name]), 
    CONSTRAINT [FK_Hotelroom_Roomnumber] FOREIGN KEY ([HotelroomNumber]) REFERENCES dbo.Hotelroom([Roomnumber]) 
)
