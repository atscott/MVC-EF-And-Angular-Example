CREATE TABLE [dbo].[tblStudent] (
    [Id]             INT           IDENTITY(1,1) PRIMARY KEY,
    [LastName]       VARCHAR (100) DEFAULT ('') NOT NULL,
    [FirstMidName]   VARCHAR (100) DEFAULT ('') NOT NULL,
    [EnrollmentDate] DATETIME      NOT NULL
);

