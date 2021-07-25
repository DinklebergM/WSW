CREATE TABLE [dbo].[BigRoom] (
    [id]               SMALLINT   NOT NULL IDENTITY,
    [RoomNumber]       SMALLINT   NOT NULL,
    [Floor]            SMALLINT   NOT NULL,
    [MaxPerson]        SMALLINT   NOT NULL,
    [Size(qm)]         SMALLINT   NOT NULL,
    [RoomClass]        SMALLINT   NULL,
    [View]             NCHAR (25) NULL,
    [SpecialEquipment] NCHAR (40) NULL
);

