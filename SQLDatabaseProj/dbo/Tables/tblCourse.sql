CREATE TABLE [dbo].[tblCourse] (
    [Id]      INT           PRIMARY KEY,
    [Title]   VARCHAR (100) DEFAULT ('') NOT NULL,
    [Credits] INT           NOT NULL
);

