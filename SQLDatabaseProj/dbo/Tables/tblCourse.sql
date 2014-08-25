CREATE TABLE [dbo].[tblCourse] (
    [Id]      INT           NOT NULL,
    [Title]   VARCHAR (100) DEFAULT ('') NOT NULL,
    [Credits] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

