CREATE TABLE [dbo].[tblStudent] (
    [Id]             INT           NOT NULL,
    [LastName]       VARCHAR (100) DEFAULT ('') NOT NULL,
    [FirstMidName]   VARCHAR (100) DEFAULT ('') NOT NULL,
    [EnrollmentDate] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

