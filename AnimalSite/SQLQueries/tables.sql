CREATE TABLE [dbo].[Dogs] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (100) NOT NULL,
    [Type]              NVARCHAR (100) NOT NULL,
    [Image]             NVARCHAR (500) NULL,
    [Male]              BIT            NOT NULL,
    [Color]             NVARCHAR (100) NOT NULL,
    [Age]               FLOAT (53)     NOT NULL,
    [Height]            FLOAT (53)     NOT NULL,
    [Weight]            FLOAT (53)     NOT NULL,
    [GoodWithChildren]  INT            NOT NULL,
    [GoodWithOtherDogs] INT            NOT NULL,
    [Shedding]          INT            NOT NULL,
    [Grooming]          INT            NOT NULL,
    [Drooling]          INT            NOT NULL,
    [GoodWithStrangers] INT            NOT NULL,
    [Playfulness]       INT            NOT NULL,
    [Protectiveness]    INT            NOT NULL,
    [Trainability]      INT            NOT NULL,
    [Energy]            INT            NOT NULL,
    [Barking]           INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Cats] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [Name]              NVARCHAR (100) NOT NULL,
    [Type]              NVARCHAR (100) NOT NULL,
    [Origin]            NVARCHAR (100) NOT NULL,
    [Length]            NVARCHAR (100) NOT NULL,
    [Image]             NVARCHAR (500) NULL,
    [Male]              BIT            NOT NULL,
    [Color]             NVARCHAR (100) NOT NULL,
    [Age]               FLOAT (53)     NOT NULL,
    [Weight]            FLOAT (53)     NOT NULL,
    [FamilyFriendly]    INT            NOT NULL,
    [Playfulness]       INT            NOT NULL,
    [Shedding]          INT            NOT NULL,
    [GeneralHealth]     INT            NOT NULL,
    [ChildrenFriendly]  INT            NOT NULL,
    [Grooming]          INT            NOT NULL,
    [Intelligence]      INT            NOT NULL,
    [OtherPetsFriendly] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Events] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (100) NOT NULL,
    [Date]     NVARCHAR (100) NOT NULL,
    [Location] NVARCHAR (100) NOT NULL,
    [Employee] NVARCHAR (100) NOT NULL,
    [Missions] NVARCHAR (MAX) NOT NULL
);

INSERT INTO [dbo].[Cats] ([Id], [Name], [Type], [Origin], [Length], [Image], [Male], [Color], [Age], [Weight], [FamilyFriendly], [Playfulness], [Shedding], [GeneralHealth], [ChildrenFriendly], [Grooming], [Intelligence], [OtherPetsFriendly]) VALUES (3, N'אלברט', N'חתול טאבי אפור קלאסי', N'', N'', N'', 0, N'אפור', 11.5, 10.5, 4, 5, 4, 5, 4, 1, 4, 5)

INSERT INTO [dbo].[Dogs] ([Id], [Name], [Type], [Image], [Male], [Color], [Age], [Height], [Weight], [GoodWithChildren], [GoodWithOtherDogs], [Shedding], [Grooming], [Drooling], [GoodWithStrangers], [Playfulness], [Protectiveness], [Trainability], [Energy], [Barking]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)

INSERT INTO [dbo].[Events] ([Id], [Name], [Date], [Location], [Employee], [Missions]) VALUES (8, N'האירוע שלי 1', N'2024-01-01', N'פארק', N'ליאת בורדו', N'<span style="font-size: 20px; font-weight: 700;">שם המשימה הראשונה</span>
מה שצריך לעשות במשימה.
זמן בערך 1.5 שעות.
<br /><br /><span style="font-size: 20px; font-weight: 700;">שם המשימה השנייה</span>
ייקח שעתיים.
')
