CREATE TABLE [dbo].[tblEnrollment] (
    [Id]        INT IDENTITY(1,1) PRIMARY KEY,
    [CourseId]  INT NOT NULL,
    [StudentId] INT NOT NULL,
    [Grade]     INT NULL,
    CONSTRAINT [FK_tblEnrollment_tblCourse] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[tblCourse] ([Id]),
    CONSTRAINT [FK_tblEnrollment_tblStudent] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[tblStudent] ([Id])
);

