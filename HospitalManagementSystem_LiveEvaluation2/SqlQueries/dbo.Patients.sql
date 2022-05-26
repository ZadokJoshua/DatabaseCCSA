CREATE TABLE [dbo].[Patients] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]       NVARCHAR (255) NULL,
    [LastName]        NVARCHAR (255) NULL,
    [Gender]          NVARCHAR (255) NULL,
    [Age]             INT            NULL,
    [Doctor_id]       INT            NULL,
    [Hospital_id]     INT            NULL,
    [Receptionist_id] INT            NULL,
    [Appointment_day] DATE NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_7A1E9FEB] FOREIGN KEY ([Doctor_id]) REFERENCES [dbo].[Doctors] ([Id]),
    CONSTRAINT [FK_20A5394C] FOREIGN KEY ([Hospital_id]) REFERENCES [dbo].[Hospital] ([Id]),
    CONSTRAINT [FK_29516BF7] FOREIGN KEY ([Receptionist_id]) REFERENCES [dbo].[Receptionist] ([Id])
);

